using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using OpenBankProject.NetCore.Models.BankAtm;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore
{
    public partial class ObpClient
    {
        private async Task<IFlurlRequest> GetBankAtmUrlAsync()
        {
            await CheckTokenAsync();

            return GetBaseUrl(_token)
                .AppendPathSegment("/banks");
        }

        public async Task<Atm> CreateAtmAsync(string bankId, Atm atm)
        {
            var response = await (await GetBankAtmUrlAsync())
                .AppendPathSegment($"/{bankId}/atms")
                .PostJsonAsync(atm)
                .ConfigureAwait(false);

            return await HandleResponseAsync<Atm>(response).ConfigureAwait(false);
        }

        public async Task<Atm> GetBankAtmAsync(string bankId, string atmId)
        {
            try
            {
                return await (await GetBankAtmUrlAsync())
                    .AppendPathSegment($"/{bankId}/atms/{atmId}")
                    .GetJsonAsync<Atm>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<Atm>> GetBankAtmsAsync(string bankId)
        {
            try
            {
                return (await (await GetBankAtmUrlAsync())
                    .AppendPathSegment($"/{bankId}/atms")
                    .GetJsonAsync<AtmList>()
                    .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }
    }
}
