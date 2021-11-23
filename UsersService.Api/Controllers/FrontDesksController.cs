using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersService.Domain.Dtos.UserDtos.FrontDeskDtos;
using UsersService.Domain.Models;
using UsersService.Domain.Processors;
using UsersService.Domain.Services.Interfaces;
using UsersService.Library.ErrorHandling;

namespace UsersService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FrontDesksController : ControllerBase
    {
        #region Fields
        private readonly IPersonUserService _service;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public FrontDesksController(IPersonUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets all front desk users.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var frontDesks = await _service.GetAll();

                if (frontDesks.ToList().Count > 0 || frontDesks != null)
                {
                    return Ok(_mapper.Map<IEnumerable<FrontDeskReadDto>>(frontDesks));
                }

                return NotFound(new ServerErrorObject("No front desk users were found."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServerErrorObject(ex.InnerException.InnerException.ToString()));
            }
        }

        /// <summary>
        /// Gets a front desk user by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetFrontDeskById/{id}", Name = "GetFrontDeskById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetFrontDeskById(int id)
        {
            try
            {
                var frontDesk = await _service.GetById(id);
                if (frontDesk != null)
                {
                    return Ok(_mapper.Map<FrontDeskReadDto>(frontDesk));
                }
                return NotFound(new ServerErrorObject($"Front desk user number {id} does not exist."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServerErrorObject(ex.InnerException.InnerException.ToString()));
                throw new ControllerException("Could not get customer by Id.", ex);
            }
        }

        /// <summary>
        /// Creates a new front desk user.
        /// </summary>
        /// <param name="frontDesk"></param>
        /// <returns></returns>
        [HttpPost("Register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateFrontDesk([FromBody] FrontDeskCreateDto frontDeskCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ServerErrorObject("Invalid input. We don't understand your request. Did you miss something somewhere?"));
                }

                var frontDesk = ModelPreProcessor.SetUserCategoryToFrontOffice(_mapper.Map<User>(frontDeskCreateDto));
                var newFrontDesk = await _service.Create(frontDesk);
                var createdFrontDesk = _mapper.Map<FrontDeskReadDto>(newFrontDesk);

                return CreatedAtRoute(nameof(GetFrontDeskById), new { id = createdFrontDesk.Id }, createdFrontDesk);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServerErrorObject("Either this entity already exists or request is invalid. " + ex.InnerException.InnerException.Message));
                throw new ControllerException("Could not create front desk user.", ex);
            }
        }

        /// <summary>
        /// Updates a front desk user's details.
        /// </summary>
        /// <param name="frontDesk"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> UpdateFrontDesk([FromBody] FrontDeskUpdateDto frontDeskUpdateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ServerErrorObject("Invalid input. We don't understand your request. Did you miss something somewhere?"));
                }
                var frontDeskToUpdate = ModelPreProcessor.SetUserCategoryToCustomer(_mapper.Map<User>(frontDeskUpdateDto));
                var updatedFrontDeskRecord = await _service.Update(frontDeskToUpdate);
                var updatedFrontDesk = _mapper.Map<FrontDeskReadDto>(updatedFrontDeskRecord);

                return CreatedAtRoute(nameof(GetFrontDeskById), new { id = updatedFrontDesk.Id }, updatedFrontDesk);
            }
            catch (Exception ex)
            {

                return StatusCode(500, new ServerErrorObject("Either the front desk user your want to update does not exist or your input is invalid. Did you miss something?"));
                throw new ControllerException("Could not update front desk user.", ex);
            }

        }

        /// <summary>
        /// Removes a front desk user.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteFrontDesk(int id)
        {
            try
            {
                _service.Delete(id);
                return Ok(new { Message = $"Front desk user {id} removed successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(400, new ServerErrorObject(ex.InnerException.InnerException.ToString()));
                throw new ControllerException("Could not delete front desk user.", ex);
            }

        }
        #endregion
    }
}
