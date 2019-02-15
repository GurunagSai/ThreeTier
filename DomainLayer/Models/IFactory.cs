
using DomainLayer.Enum;

namespace DomainLayer.Models
{
    public interface IFactory
    {
        IRegistrationModel GetModel(UserOptionEnum model);

    }
}
