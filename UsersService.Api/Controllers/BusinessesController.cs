using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersService.Domain.Dtos.BusinessDtos;
using UsersService.Domain.Models;
using UsersService.Domain.Processors;
using UsersService.Domain.Services.Interfaces;
using UsersService.Library.ErrorHandling;

namespace UsersService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessesController : ControllerBase
    {
        #region Fields
        private readonly IBusinessService _service;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public BusinessesController(IBusinessService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets all businesses.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var businesses = await _service.GetAll();

                if (businesses.ToList().Count > 0 || businesses != null)
                {
                    return Ok(_mapper.Map<IEnumerable<BusinessReadDto>>(businesses));
                }

                return NotFound(new ServerErrorObject("No Businesses were found."));
            }
            catch (Exception)
            {
                return StatusCode(500, new ServerErrorObject());
            }
        }

        /// <summary>
        /// Gets a customer by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetBusinessById/{id}", Name = "GetBusinessById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetBusinessById(int id)
        {
            try
            {
                var business = await _service.GetById(id);
                if (business != null)
                {
                    return Ok(_mapper.Map<BusinessReadDto>(business));
                }

                return NotFound(new ServerErrorObject($"Business number {id} does not exist."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServerErrorObject());
                throw new ControllerException("Could not get business by Id.", ex);
            }
        }

        /// <summary>
        /// Creates a new business.
        /// </summary>
        /// <param name="businessCreateDto"></param>
        /// <returns></returns>
        [HttpPost("Register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateBusiness([FromBody] BusinessCreateDto businessCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ServerErrorObject("Invalid input. We don't understand your request. Did you miss something somewhere?"));
                }

                var business = ModelPreProcessor.ProcessBusiness(_mapper.Map<Business>(businessCreateDto));
                var newBusiness = await _service.Create(business);
                var createdBusiness = _mapper.Map<BusinessReadDto>(newBusiness);

                return CreatedAtRoute(nameof(GetBusinessById), new { id = createdBusiness.Id }, createdBusiness);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServerErrorObject("Either this entity already exists or request is invalid. " + ex.InnerException.InnerException.Message));
                throw new ControllerException("Could not create customer.", ex);
            }
        }

        /// <summary>
        /// Updates a business's details.
        /// </summary>
        /// <param name="business"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> UpdateBusiness([FromBody] BusinessUpdateDto businessUpdateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ServerErrorObject("Invalid input. We don't understand your request. Did you miss something somewhere?"));
                }
                var businessToUpdate = _mapper.Map<Business>(businessUpdateDto);
                var updatedBusinessRecord = await _service.Update(businessToUpdate);
                var updatedBusiness = _mapper.Map<BusinessReadDto>(updatedBusinessRecord);

                return CreatedAtRoute(nameof(GetBusinessById), new { id = updatedBusiness.Id }, updatedBusiness);
            }
            catch (Exception ex)
            {

                return StatusCode(500, new ServerErrorObject("Either the business your want to update does not exist or your input is invalid. Did you miss something?"));
                throw new ControllerException("Could not update business.", ex);
            }

        }

        /// <summary>
        /// Removes a business.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteBusiness(int id)
        {
            try
            {
                _service.Delete(id);
                return Ok(new { Message = $"Business {id} removed successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(400, new ServerErrorObject(ex.InnerException.InnerException.ToString()));
                throw new ControllerException("Could not delete business.", ex);
            }

        }
        #endregion
    }
}
