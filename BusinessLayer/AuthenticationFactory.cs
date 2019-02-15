using DataLayer;
using DomainLayer.Enum;
using DomainLayer.Models;
namespace BusinessLayer
{
    public class AuthenticationFactory:IFactory
    {
        private string m_EmailId { get; set; }
        private string m_Password { get; set; }
        private string m_ConfirmPassword { get; set; }
        private string m_FirstName { get; set; }
        private string m_LastName { get; set; }
        private bool m_IsStudent { get; set; }
        public AuthenticationFactory(string emailId, string password)
        {
            m_EmailId = emailId;
            m_Password = password;
        }
        public AuthenticationFactory(string emailId, string password, string confirmPassword, string firstName, string lastName, bool isStudent)
        {
            m_EmailId = emailId;
            m_Password = password;
            m_ConfirmPassword = confirmPassword;
            m_FirstName = firstName;
            m_LastName = lastName;
            m_IsStudent = isStudent;
        }
        public IRegistrationModel GetModel(UserOptionEnum model)
        {
            switch (model)
            {
                case UserOptionEnum.Login:
                    {
                        return new AuthenticationData(m_EmailId, m_Password);    
                    }
                case UserOptionEnum.Registration:
                    {
                        return new AuthenticationData(m_EmailId, m_Password, m_ConfirmPassword, m_FirstName, m_LastName, m_IsStudent);
                    }
                default:
                    {
                        return null;
                    }
            }   
        }
    }
}
