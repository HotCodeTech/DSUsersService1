using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersService.Domain.Dtos.UserDtos.MechanicDtos;
using UsersService.Domain.Models;
using UsersService.Domain.Processors;
using UsersService.Domain.Services.Interfaces;
using UsersService.Library.ErrorHandling;

namespace UsersService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MechanicsController : ControllerBase
    {
        #region Fields
        private readonly IPersonUserService _service;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public MechanicsController(IPersonUserService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Gets all mechanics.
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var mechanics = await _service.GetAll();

                if (mechanics.ToList().Count > 0 || mechanics != null)
                {
                    return Ok(_mapper.Map<IEnumerable<MechanicReadDto>>(mechanics));
                }

                return NotFound(new ServerErrorObject("No mechanics were found."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServerErrorObject(ex.InnerException.InnerException.ToString()));
            }
        }

        /// <summary>
        /// Gets a mechanic by Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("GetMechanicById/{id}", Name = "GetMechanicById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> GetMechanicById(int id)
        {
            try
            {
                var mechanic = await _service.GetById(id);
                if (mechanic != null)
                {
                    return Ok(_mapper.Map<MechanicReadDto>(mechanic));
                }
                return NotFound(new ServerErrorObject($"Mechanic number {id} does not exist."));
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServerErrorObject(ex.InnerException.InnerException.ToString()));
                throw new ControllerException("Could not get mechanic by Id.", ex);
            }
        }

        /// <summary>
        /// Creates a new front desk user.
        /// </summary>
        /// <param name="mechanic"></param>
        /// <returns></returns>
        [HttpPost("Register")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateMechanic([FromBody] MechanicCreateDto mechanicCreateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ServerErrorObject("Invalid input. We don't understand your request. Did you miss something somewhere?"));
                }

                var mechanic = ModelPreProcessor.SetUserCategoryToMechanic(_mapper.Map<User>(mechanicCreateDto));
                var newMechanic = await _service.Create(mechanic);
                var createdMechanic = _mapper.Map<MechanicReadDto>(newMechanic);

                return CreatedAtRoute(nameof(GetMechanicById), new { id = createdMechanic.Id }, createdMechanic);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new ServerErrorObject("Either this entity already exists or request is invalid. " + ex.InnerException.InnerException.Message));
                throw new ControllerException("Could not create mechanic.", ex);
            }
        }

        /// <summary>
        /// Updates a mechanic's details.
        /// </summary>
        /// <param name="mechanic"></param>
        /// <returns></returns>
        [HttpPut("Update")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> UpdateMechanic([FromBody] MechanicUpdateDto mechanicUpdateDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(new ServerErrorObject("Invalid input. We don't understand your request. Did you miss something somewhere?"));
                }
                var mechanicToUpdate = ModelPreProcessor.SetUserCategoryToMechanic(_mapper.Map<User>(mechanicUpdateDto));
                var updatedMechanicRecord = await _service.Update(mechanicToUpdate);
                var updatedMechanic = _mapper.Map<MechanicReadDto>(updatedMechanicRecord);

                return CreatedAtRoute(nameof(GetMechanicById), new { id = updatedMechanic.Id }, updatedMechanic);
            }
            catch (Exception ex)
            {

                return StatusCode(500, new ServerErrorObject("Either the mechanic your want to update does not exist or your input is invalid. Did you miss something?"));
                throw new ControllerException("Could not update mechanic.", ex);
            }

        }

        /// <summary>
        /// Removes a mechanic.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("Delete/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteMechanic(int id)
        {
            try
            {
                _service.Delete(id);
                return Ok(new { Message = $"Mechanic {id} removed successfully!" });
            }
            catch (Exception ex)
            {
                return StatusCode(400, new ServerErrorObject(ex.InnerException.InnerException.ToString()));
                throw new ControllerException("Could not delete mechanic.", ex);
            }

        }
        #endregion

    }
}
