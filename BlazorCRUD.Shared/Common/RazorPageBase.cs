using Microsoft.AspNetCore.Components;

namespace BlazorCRUD.Shared.Base
{
    public static class RazorPageBase
    {
        [Inject]
        public static NavigationManager naviManager { get; set; }
    }
}
