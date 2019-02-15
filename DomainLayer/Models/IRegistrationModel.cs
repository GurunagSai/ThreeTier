
namespace DomainLayer.Models
{
    public interface IRegistrationModel
    {
        string EmailId { get;  }
        string Password { get;  }       
        string ConfirmPassword { get;  }
        string FirstName { get;  }
        string LastName { get;  }
        bool IsStudent { get;  }
        string ValidateLogin();
        string Register();
    }
}
