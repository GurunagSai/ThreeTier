using DomainLayer.Enum;
using DataLayer;
using System.Data.SqlClient;
using System.Collections.Generic;
using DomainLayer.Models;

namespace BusinessLayer
{
    public class UserBusiness
    {
        UserData _userData;
        public UserBusiness()
        {
            _userData = new UserData();
        }
        /// <summary>
        /// method to get user details
        /// </summary>
        /// <param name="role">user choice enumeration</param>
        /// <returns></returns>
        public List<UserModel> GetUserDetails(UserChoiceEnum role)
        {
            return _userData.GetUserDetails(role);
        }
    }
}
