using BlazorCRUD.Shared.Models;
using System.Net.Http.Json;

namespace BlazorCRUD.Client.Services
{
    public class SharedResourceService 
    {
        protected readonly HttpClient httpclient;

        public SharedResource SrItem { get; set; } = new SharedResource();

        public SharedResourceService(HttpClient _httpclient)
        {
            this.httpclient = _httpclient;
        }

        public async Task<IEnumerable<SharedResource>> GetSharedResources()
        {
            return await httpclient.GetFromJsonAsync<IEnumerable<SharedResource>>("Api/GetSharedResources");
        }
    }
}
