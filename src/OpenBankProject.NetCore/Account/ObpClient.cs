﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using OpenBankProject.NetCore.Models.Account;
using OpenBankProject.NetCore.Models.Common;

namespace OpenBankProject.NetCore
{
    public partial class ObpClient
    {
        private async Task<IFlurlRequest> GetAccountUrlAsync()
        {
            await CheckTokenAsync();

            return GetBaseUrl(_token);
        }

        public async Task<CreateAccount> CreateAccountAsync(string bankId, string accountId, CreateAccount account)
        {
            var response = await (await GetAccountUrlAsync())
                .AppendPathSegment($"/banks/{bankId}/accounts/{accountId}")
                .PostJsonAsync(account)
                .ConfigureAwait(false);

            return await HandleResponseAsync<CreateAccount>(response).ConfigureAwait(false);
        }

        public async Task<Account> GetAccountByIdAsync(string bankId, string accountId)
        {
            try
            {
                return await (await GetAccountUrlAsync())
                    .AppendPathSegment($"/banks/{bankId}/accounts/{accountId}/account")
                    .GetJsonAsync<Account>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<Account> GetAccountByIdAsync(string bankId, string accountId, string viewId)
        {
            try
            {
                return await (await GetAccountUrlAsync())
                    .AppendPathSegment($"/banks/{bankId}/accounts/{accountId}/{viewId}/account")
                    .GetJsonAsync<Account>()
                    .ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<BankAccount>> GetAccountsHeldAsync(string bankId)
        {
            try
            {
                return (await (await GetAccountUrlAsync())
                    .AppendPathSegment($"/banks/{bankId}/accounts-held")
                    .GetJsonAsync<BankAccountList>()
                    .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<WithId>> GetAccountIdsAsync(string bankId)
        {
            try
            {
                return (await (await GetAccountUrlAsync())
                    .AppendPathSegment($"/banks/{bankId}/accounts/account_ids/private")
                    .GetJsonAsync<AccountIdList>()
                    .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<AccountWithViews>> GetAccountsWithViewsAsync(string bankId)
        {
            try
            {
                return (await (await GetAccountUrlAsync())
                    .AppendPathSegment($"/banks/{bankId}/accounts/private")
                    .GetJsonAsync<AccountWithViewsList>()
                    .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<AccountWithViewsAvailable>> GetAccountsAsync(string bankId)
        {
            try
            {
                return (await (await GetAccountUrlAsync())
                    .AppendPathSegment($"/banks/{bankId}/accounts")
                    .GetJsonAsync<AccountWithViewsAvailableList>()
                    .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }
        }

        public async Task<IEnumerable<AccountWithViews>> GetPrivateAccountsAtAllBanksAsync()
        {
            try
            {
                return (await (await GetAccountUrlAsync())
                    .AppendPathSegment("/my/accounts")
                    .GetJsonAsync<AccountWithViewsList>()
                    .ConfigureAwait(false))
                    .GetEnumerableResults();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResponse>();
                throw new FlurlHttpException(ex.Call, errorResponse.Error, ex);
            }

        }

        public async Task<bool> UpdateAccountLabelAsync(string bankId, string accountId, string id, string label)
        {
            var data = new
            {
                id,
                label,
                bank_id = bankId
            };

            var response = await (await GetAccountUrlAsync())
                .AppendPathSegment($"/{bankId}/accounts/{accountId}")
                .PostJsonAsync(data)
                .ConfigureAwait(false);

            var result = await HandleResponseAsync<SuccessResponse>(response).ConfigureAwait(false);
            return result.Success == "Success";
        }
    }
}
