using System.Threading.Tasks;
using Flurl.Http;
using OpenBankProject.NetCore.Models.Api;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore
{
    public partial class ObpClient
    {
        private async Task<IFlurlRequest> GetApiUrlAsync()
        {
            await CheckTokenAsync();

            return GetBaseUrl(_token);
        }

        public async Task<ApiConfiguration> GetApiConfigurationAsync()
        {
            try
            {
                return await (await GetApiUrlAsync())
                    .AppendPathSegment("/config")
                    .GetJsonAsync<ApiConfiguration>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<ApiInformation> GetApiInformationAsync()
        {
            return await (await GetApiUrlAsync())
                .AppendPathSegment("/root")
                .GetJsonAsync<ApiInformation>()
                .ConfigureAwait(false);
        }

        public async Task<AdapterInformation> GetAdapterInformationAsync(string bankId)
        {
            try
            {
                return await (await GetApiUrlAsync())
                    .AppendPathSegment($"/banks/{bankId}/adapter")
                    .GetJsonAsync<AdapterInformation>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }
    }
}
