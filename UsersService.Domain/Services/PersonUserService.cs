using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersService.Data.Entities;
using UsersService.Data.Interfaces;
using UsersService.Domain.Models;
using UsersService.Domain.Services.Interfaces;
using UsersService.Library.ErrorHandling;

namespace UsersService.Domain.Services
{
    public class PersonUserService : IPersonUserService
    {
        #region Fields
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public PersonUserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<User> Create(User personUser)
        {
            try
            {
                var personUserEntity = _mapper.Map<UserEntity>(personUser);
                await _unitOfWork.UserRepository.Create(personUserEntity);
                _unitOfWork.Complete();

                var createdPersonUserEntity = await _unitOfWork.UserRepository.GetById(personUserEntity.Id);
                return _mapper.Map<User>(createdPersonUserEntity);
            }
            catch (Exception ex)
            {

                throw new ServiceException("This person user already exists.", ex);
            }
            
        }

        public void Delete(object id)
        {
            try
            {
                _unitOfWork.UserRepository.Delete(id);
                _unitOfWork.Complete();
            }
            catch (Exception ex)
            {

                throw new ServiceException("Could not delete this person user.", ex);
            }
           
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            try
            {
                var personUserEntities = await _unitOfWork.UserRepository.GetAll();
                if (personUserEntities != null)
                {
                    foreach (var entity in personUserEntities)
                    {
                        entity.Address = _unitOfWork.AddressRepository.GetByIdentifier(entity.Identifier);
                        entity.UserProfile = _unitOfWork.ProfileRepository.GetByIdentifier(entity.Identifier);
                        entity.UserProfile.ProfilePic = _unitOfWork.ProfilePicRepository.GetByIdentifier(entity.Identifier);
                    }
                }
                return _mapper.Map<IEnumerable<UserEntity>, IEnumerable<User>>(personUserEntities);
            }
            catch (Exception ex)
            {

                throw new ServiceException("Could not retrieve all the person users.", ex);
            }
           
        }

        public async Task<User> GetById(object id)
        {
            try
            {
                var personUserEntity = await _unitOfWork.UserRepository.GetById(id);
                if (personUserEntity != null)
                {

                    personUserEntity.Address = _unitOfWork.AddressRepository.GetByIdentifier(personUserEntity.Identifier);
                    personUserEntity.UserProfile = _unitOfWork.ProfileRepository.GetByIdentifier(personUserEntity.Identifier);
                    personUserEntity.UserProfile.ProfilePic = _unitOfWork.ProfilePicRepository.GetByIdentifier(personUserEntity.Identifier);
                }
                
                return _mapper.Map<User>(personUserEntity);
            }
            catch (Exception ex)
            {

                throw new ServiceException("Could not retrieve this person user by Id.", ex);
            }
           
        }

        public async Task<User> Update(User personUser)
        {
            try
            {
                var personUserEntity = _mapper.Map<UserEntity>(personUser);
                _unitOfWork.UserRepository.Update(personUserEntity);
                _unitOfWork.AddressRepository.Update(personUserEntity.Address);
                _unitOfWork.ProfileRepository.Update(personUserEntity.UserProfile);
                _unitOfWork.ProfilePicRepository.Update(personUserEntity.UserProfile.ProfilePic);
                _unitOfWork.Complete();

                var updatedCustomerEntity = await _unitOfWork.UserRepository.GetById(personUserEntity.Id);
                return _mapper.Map<User>(updatedCustomerEntity);
            }
            catch (Exception ex)
            {

                throw new ServiceException("Could not update this person user.", ex);
            }
            
        }

        #endregion

    }
}
