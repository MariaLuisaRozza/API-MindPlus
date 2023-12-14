using Dapper;
using MindPlusForm.Contracts.Repository;
using MindPlusForm.Entity;
using MindPlusForm.Infrastructure;

namespace MindPlusForm.Repository
{
    public class LoginRepository : Connection, ILoginRepository
    {
        public async Task<EmployeeEntity> LoginAuthentication(string email, string password)
        {
            string sql = "SELECT * FROM employees WHERE Email = @Email AND Password = @Password";
            return await GetConnection().QueryFirstAsync<EmployeeEntity> (sql, new { email, password });
        }
    }
}
