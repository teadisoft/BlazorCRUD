using Blazor.ModalDialog;
using BlazorCRUD.Client.Pages.Popups;
using BlazorCRUD.Client.Services;
using BlazorCRUD.Shared.Base;
using BlazorCRUD.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;


namespace BlazorCRUD.Client.Pages.SharedResource
{
    public partial class SharedResourceList : ComponentBase
    {
        ILogger<SharedResourceList> _logger;

        [Inject]
        SharedResourceService SharedResourceService { get; set; }

        [Inject]
        NavigationManager naviManager { get; set; }

        [Inject]
        IModalDialogService ModalDialog { get; set; }

        IEnumerable<SharedResourceModel> SharedResources { get; set; }

        public bool IsEditSharedResource { get; set; } = false;

        public SharedResourceList()
        {}

        protected override async Task OnInitializedAsync()
        {
            SharedResources = await SharedResourceService.GetSharedResources();

            _logger.LogWarning("warning");
            _logger.LogError("error");


        }

        public void OnCreate()
        {
            ModalDialogOptions model = new()
            {
                BackgroundClickToClose = false
            };
            ModalDialog.ShowDialogAsync<EditSharedResource>("Create", model);
        }

        private GoPopup popupRef;

        public void OnPopup()
        {
            popupRef.Show("Popup body text");
        }
    }
}
