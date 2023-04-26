using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShopHRM.App.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee? Employee { get; set; }

    }
}
