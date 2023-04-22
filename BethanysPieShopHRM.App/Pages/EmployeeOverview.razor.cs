using BethanysPieShopHRM.App.Services;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeOverview
    {
        [Inject]
        public IEmployeeService? EmployeeService { get; set; }

        public List<Employee>? Employees { get; set; }

        protected override async Task OnInitializedAsync()
        {
            if (EmployeeService is not null)
            {
                Employees = await EmployeeService.GetEmployees();
            }
        }
    }
}
