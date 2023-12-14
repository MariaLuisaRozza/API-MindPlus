using MindPlusForm.Entity;

namespace MindPlusForm.Contracts.Repository
{
    public interface ILoginRepository
    {
        Task<EmployeeEntity> LoginAuthentication(string email, string password);
       
    }
}
