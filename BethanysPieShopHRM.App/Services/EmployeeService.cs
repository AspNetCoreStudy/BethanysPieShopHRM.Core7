using BethanysPieShopHRM.Shared.Domain;
using System.Net.Http.Json;

namespace BethanysPieShopHRM.App.Services
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
    }

    public class EmployeeService : IEmployeeService
    {
        private HttpClient http;
        public EmployeeService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            List<Employee>? ees = await http
            .GetFromJsonAsync<List<Employee>>("sample-data/employees.json");


            return ees ?? default!;
        }
    }
}