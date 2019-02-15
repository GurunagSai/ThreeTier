using DomainLayer.Enum;
using DomainLayer.Models;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer
{
    public class UserData
    {

        public List<UserModel> GetUserDetails(UserChoiceEnum role)
        {
            if (role == UserChoiceEnum.Student)
            {
                return DataSource._userList.Where(m => m.IsStudent).ToList();
            }
            else if(role==UserChoiceEnum.Other)
            {
                return DataSource._userList.Where(m => !m.IsStudent).ToList();
            }
            else
            {
                return DataSource._userList;
            }
        }

    }
}
