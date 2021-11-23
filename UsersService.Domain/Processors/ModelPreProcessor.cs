using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsersService.Domain.Models;

namespace UsersService.Domain.Processors
{
    public static class ModelPreProcessor
    {
        public static User SetUserCategoryToCustomer(User user)
        {
            user.UserCategory = 1;
            user.Address.Identifier = user.Identifier;
            user.UserProfile.Identifier = user.Identifier;
            if (user.UserProfile.ProfilePic != null)
            {
                user.UserProfile.ProfilePic.Identifier = user.Identifier;
            }
            
            return user;
        }

        public static User SetUserCategoryToFrontOffice(User user)
        {
            user.UserCategory = 2;
            user.Address.Identifier = user.Identifier;
            user.UserProfile.Identifier = user.Identifier;
            if (user.UserProfile.ProfilePic != null)
            {
                user.UserProfile.ProfilePic.Identifier = user.Identifier;
            }
            return user;
        }

        public static User SetUserCategoryToMechanic(User user)
        {
            user.UserCategory = 3;
            user.Address.Identifier = user.Identifier;
            user.UserProfile.Identifier = user.Identifier;
            if (user.UserProfile.ProfilePic != null)
            {
                user.UserProfile.ProfilePic.Identifier = user.Identifier;
            }
            return user;
        }

        public static User SetUserCategoryToBackOffice(User user)
        {
            user.UserCategory = 4;
            user.Address.Identifier = user.Identifier;
            user.UserProfile.Identifier = user.Identifier;
            if (user.UserProfile.ProfilePic != null)
            {
                user.UserProfile.ProfilePic.Identifier = user.Identifier;
            }
            return user;
        }

        public static User SetUserCategoryToAdmin(User user)
        {
            user.UserCategory = 5;
            user.Address.Identifier = user.Identifier;
            user.UserProfile.Identifier = user.Identifier;
            if (user.UserProfile.ProfilePic != null)
            {
                user.UserProfile.ProfilePic.Identifier = user.Identifier;
            }
            return user;
        }

        public static Business ProcessBusiness(Business business)
        {
            business.Address.Identifier = business.Identifier;
            business.BusinessProfile.Identifier = business.Identifier;
            if (business.BusinessProfile.ProfilePic != null)
            {
                business.BusinessProfile.ProfilePic.Identifier = business.Identifier;
            }

            return business;
        }

    }
}
