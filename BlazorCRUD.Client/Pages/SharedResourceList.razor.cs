using Blazor.ModalDialog;
using BlazorCRUD.Client.Services;
using BlazorCRUD.Shared.Base;
using BlazorCRUD.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorCRUD.Client.Pages
{
    public partial class SharedResourceList : ComponentBase
    {
        [Inject]
        SharedResourceService SharedResourceService { get; set; }

        [Inject]
        NavigationManager naviManager { get; set; }

        [Inject]
        IModalDialogService ModalDialog { get; set; }

        IEnumerable<SharedResource> SharedResources { get; set; }

        public bool IsEditSharedResource { get; set; } = false;

        public SharedResourceList()
        {}

        protected override async Task OnInitializedAsync()
        {
            SharedResources = await SharedResourceService.GetSharedResources();
        }

        public void OnCreate()
        {
            ModalDialogOptions model = new()
            {
                BackgroundClickToClose = false
            };
            ModalDialog.ShowDialogAsync<EditSharedResource>("Create", model);
        }
    }
}
