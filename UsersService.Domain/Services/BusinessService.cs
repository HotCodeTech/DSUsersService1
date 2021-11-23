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
    public class BusinessService : IBusinessService
    {
        #region Fields
        private IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public BusinessService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion

        #region Methods
        public async Task<Business> Create(Business business)
        {

            try
            {
                var businessEntity = _mapper.Map<BusinessEntity>(business);
                await _unitOfWork.BusinessRepository.Create(businessEntity);
                _unitOfWork.Complete();

                var createdBusinessEntity = await _unitOfWork.BusinessRepository.GetById(businessEntity.Id);
                return  _mapper.Map<Business>(createdBusinessEntity);
            }
            catch (Exception ex)
            {
                throw new ServiceException("A business with the provided details already exists.", ex);
            }
        }

        public void Delete(object id)
        {
            try
            {
                _unitOfWork.BusinessRepository.Delete(id);
                _unitOfWork.Complete();
            }
            catch (Exception ex)
            {
                throw new ServiceException("Could not delete this business.", ex);
            }
        }

        public async Task<IEnumerable<Business>> GetAll()
        {
            try
            {
                var businessEntities = await _unitOfWork.BusinessRepository.GetAll();
                if (businessEntities != null)
                {
                    var entities = businessEntities.ToList();
                    foreach (var entity in entities)
                    {
                        entity.Address = _unitOfWork.BusinessAddressRepository.GetByIdentifier(entity.Identifier);
                        entity.BusinessProfile = _unitOfWork.BusinessProfileRepository.GetByIdentifier(entity.Identifier);
                        entity.BusinessProfile.ProfilePic = _unitOfWork.BusinessProfilePicRepository.GetByIdentifier(entity.Identifier);
                    }
                }
                return _mapper.Map<IEnumerable<BusinessEntity>, IEnumerable<Business>>(businessEntities);
            }
            catch (Exception ex)
            {
                throw new ServiceException("Could not retrieve all the businesses.", ex);
            }
        }

        public async Task<Business> GetById(object id)
        {
            try
            {
                var businessEntity = await _unitOfWork.BusinessRepository.GetById(id);
                if (businessEntity != null)
                {
                    businessEntity.Address = _unitOfWork.BusinessAddressRepository.GetByIdentifier(businessEntity.Identifier);
                    businessEntity.BusinessProfile = _unitOfWork.BusinessProfileRepository.GetByIdentifier(businessEntity.Identifier);
                    businessEntity.BusinessProfile.ProfilePic = _unitOfWork.BusinessProfilePicRepository.GetByIdentifier(businessEntity.Identifier);
                }
                return _mapper.Map<Business>(businessEntity);  
            }
            catch (Exception ex)
            {
                throw new ServiceException("Could not retrieve this business by Id.", ex);

            }
        }

        public async Task<Business> Update(Business business)
        {
            try
            {
                var businessEntity = _mapper.Map<BusinessEntity>(business);
                _unitOfWork.BusinessRepository.Update(businessEntity);
                _unitOfWork.BusinessAddressRepository.Update(businessEntity.Address);
                _unitOfWork.BusinessProfileRepository.Update(businessEntity.BusinessProfile);
                _unitOfWork.BusinessProfilePicRepository.Update(businessEntity.BusinessProfile.ProfilePic);
                _unitOfWork.Complete();

                var updatedBusinessEntity = await _unitOfWork.BusinessRepository.GetById(businessEntity.Id);
                return _mapper.Map<Business>(updatedBusinessEntity);
            }
            catch (Exception ex)
            {
                throw new ServiceException("Could not update this business.", ex);

            }
        }
       
        #endregion

    }
}
