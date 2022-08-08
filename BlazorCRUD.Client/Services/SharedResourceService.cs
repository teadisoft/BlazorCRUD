using BlazorCRUD.Shared.Models;
using System.Net.Http.Json;

namespace BlazorCRUD.Client.Services
{
    public class SharedResourceService 
    {
        protected readonly HttpClient httpclient;

        public SharedResourceModel SrItem { get; set; } = new SharedResourceModel();

        public SharedResourceService(HttpClient _httpclient)
        {
            this.httpclient = _httpclient;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<SharedResourceModel>?> GetSharedResources()
        {
           return await httpclient.GetFromJsonAsync<IEnumerable<SharedResourceModel>?>("Api/GetSharedResources");
        }
    }
}
