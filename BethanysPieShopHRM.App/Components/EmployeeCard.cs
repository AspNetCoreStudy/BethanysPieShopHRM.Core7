using BethanysPieShopHRM.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace BethanysPieShopHRM.App.Components
{
    public partial class EmployeeCard
    {
        [Parameter]
        public Employee? Employee { get; set; }

        [Parameter]
        public EventCallback<Employee> OnClickQuickView { get; set; }

        public void OnClickQuickViewInternal(MouseEventArgs e)
        {
            OnClickQuickView.InvokeAsync(Employee);
        }

    }
}
