using Blazor.ModalDialog;
using BlazorCRUD.Client.Services;
using BlazorCRUD.Shared.Models;
using Microsoft.AspNetCore.Components;


namespace BlazorCRUD.Client.Pages.SharedResource
{
    public partial class DetailSharedResource : ComponentBase
    {
        [Parameter]
        public SharedResourceModel Sr { get; set; } = new();

        [Inject]
        SharedResourceService SharedResourceService { get; set; }

        [Inject]
        IModalDialogService ModalDialog { get; set; }

        protected override async Task OnInitializedAsync()
        {
            Sr = SharedResourceService.SrItem;
        }

        private void OnOk()
        {
            ModalDialog.Close(true);
        }
    }
}
