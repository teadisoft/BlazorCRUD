using Blazor.ModalDialog;
using BlazorCRUD.Client.Services;
using BlazorCRUD.Shared.Base;
using BlazorCRUD.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorCRUD.Client.Pages
{
    public partial class EditSharedResource : ComponentBase
    {
        [Inject]
        SharedResourceService SharedResourceService { get; set; }

        [Inject]
        NavigationManager NaviManager { get; set; }

        [Inject]
        IModalDialogService ModalDialog { get; set; }

        [Parameter]
        public SharedResource Sr { get; set; } = new();

        public EditSharedResource()
        {
        }

        protected override void OnInitialized()
        {
        }

        private async void OnCreate()
        {
            SharedResourceService.SrItem = Sr;

            MessageBoxDialogResult result = await ModalDialog.ShowMessageBoxAsync("Create", 
                "Are you sure you want to Create?", MessageBoxButtons.YesNo, MessageBoxDefaultButton.Button2);

            if (result == MessageBoxDialogResult.No)
                return;

            ModalDialog.Close(true);
        }

        private void OnCancel()
        {
            ModalDialog.Close(true);
        }
    }
}
