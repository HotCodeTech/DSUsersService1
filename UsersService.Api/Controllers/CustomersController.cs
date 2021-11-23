using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersService.Domain.Dtos.UserDtos.CustomerDtos;
using UsersService.Domain.Models;
using UsersService.Domain.Processors;
using UsersService.Domain.Services.Interfaces;
using UsersService.Library.ErrorHandling;

namespace UsersService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        #region Fields
        private readonly IPersonUserService _service;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public CustomersController(IPersonUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Gets all customers.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var customers = await _service.GetAll();

                if (customers.ToList().Count > 0 || customers != null)
                {
                    return Ok(_mapper.Map<IEnumerable<CustomerReadDto>>(customers));
                }

                return NotFound(new ServerErrorObject("No Customers were found."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServerErrorObject(ex.InnerException.InnerException.ToString()));
            }
        }

        /// <summary>
        /// Gets a customer by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetCustomerById/{id}", Name ="GetCustomerById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetCustomerById(int id)
        {
            try
            {
                var customer = await _service.GetById(id);
                if (customer != null)
                {
                    return Ok(_mapper.Map<CustomerReadDto>(customer));
                }
                return NotFound(new ServerErrorObject($"Customer number {id} does not exist."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServerErrorObject(ex.InnerException.InnerException.ToString()));
                throw new ControllerException("Could not get customer by Id.", ex);
            }
        }

        /// <summary>
        /// Creates a new customer.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost("Register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateCustomer([FromBody] CustomerCreateDto customerCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ServerErrorObject("Invalid input. We don't understand your request. Did you miss something somewhere?"));
                }

                var customer = ModelPreProcessor.SetUserCategoryToCustomer(_mapper.Map<User>(customerCreateDto));
                var newCustomer = await _service.Create(customer);
                var createdCustomer = _mapper.Map<CustomerReadDto>(newCustomer);

                return CreatedAtRoute(nameof(GetCustomerById), new { id = createdCustomer.Id }, createdCustomer);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServerErrorObject("Either this entity already exists or request is invalid. " + ex.InnerException.InnerException.Message));
                throw new ControllerException("Could not create customer.", ex);
            }


        }

        /// <summary>
        /// Updates a customer's details.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> UpdateCustomer([FromBody] CustomerUpdateDto customerUpdateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ServerErrorObject("Invalid input. We don't understand your request. Did you miss something somewhere?"));
                }
                var customerToUpdate = ModelPreProcessor.SetUserCategoryToCustomer(_mapper.Map<User>(customerUpdateDto));
                var updatedCustomerRecord = await _service.Update(customerToUpdate);
                var updatedCustomer = _mapper.Map<CustomerReadDto>(updatedCustomerRecord);

                return CreatedAtRoute(nameof(GetCustomerById), new { id = updatedCustomer.Id }, updatedCustomer);
            }
            catch (Exception ex)
            {

                return StatusCode(500, new ServerErrorObject("Either the customer your want to update does not exist or your input is invalid. Did you miss something?"));
                throw new ControllerException("Could not update customer.", ex);
            }
            
        }

        /// <summary>
        /// Removes a customer.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteCustomer(int id)
        {
            try
            {
                _service.Delete(id);
                return Ok(new { Message = $"Customer {id} removed successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(400, new ServerErrorObject(ex.InnerException.InnerException.ToString()));
                throw new ControllerException("Could not delete customer.", ex);
            }
           
        }


       
        #endregion
    }
}

