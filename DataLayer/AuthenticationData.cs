using DomainLayer.Models;
using System.Data.SqlClient;
using DomainLayer;
using System.Linq;

namespace DataLayer
{
    public class AuthenticationData : IRegistrationModel
    {
        public string EmailId { get; }
        public string Password { get;  }
        public string ConfirmPassword { get; }
        public string FirstName { get; }
        public string LastName { get;  }
        public bool IsStudent { get;  }

        public AuthenticationData(string emailId, string password)
        {
             EmailId = emailId;
             Password = password;
        }

        public AuthenticationData(string emailId, string password, string conformPassword, string firstName, string lastName, bool isStudent)
        {
            EmailId = emailId;
            Password = password;
            ConfirmPassword = conformPassword;
            FirstName = firstName;
            LastName = lastName;
            IsStudent = isStudent;
        }

        /// <summary>
        /// validates the login credintals
        /// </summary>
        /// <returns></returns>
        public string ValidateLogin()
        {

            if (DataSource._userList.Any(m => m.EmailId == EmailId && m.Password == Password))
            {
                return StringLiterals.LoginSuccessful;
            }
            return StringLiterals.LoginUnsuccessful; 
        }

        /// <summary>
        /// registers a user
        /// </summary>
        /// <returns></returns>
        public string Register()
        {
            if (!DataSource._userList.Any(m => m.EmailId == EmailId))
            {
                UserModel userModel = new UserModel();
                userModel.EmailId = EmailId;
                userModel.Password = Password;
                userModel.FirstName = FirstName;
                userModel.LastName = LastName;
                userModel.IsStudent = IsStudent;
                DataSource._userList.Add(userModel);
                return StringLiterals.RegistrationSucces;
            }

            return StringLiterals.AlreadyEmail;
        }
    }
}
