using Blazor.ModalDialog;
using BlazorCRUD.Client.Services;
using BlazorCRUD.Shared.Base;
using BlazorCRUD.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorCRUD.Client.Pages.SharedResource
{
    public partial class EditSharedResource : ComponentBase
    {
        [Inject]
        SharedResourceService SharedResourceService { get; set; }

        [Inject]
        NavigationManager NaviManager { get; set; }

        [Inject]
        IModalDialogService ModalDialog { get; set; }

        Dictionary<string, object> inputTextAreaAttributes = new Dictionary<string, object>();

        [Parameter]
        public SharedResourceModel Sr { get; set; } = new();

        public EditSharedResource()
        {
        }

        protected override void OnInitialized()
        {
            inputTextAreaAttributes.Add("rows", "5");
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
