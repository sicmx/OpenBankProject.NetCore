﻿using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OpenBankProject.NetCore.Tests
{
    public partial class ObpClientShould
    {
        [Fact]
        public async Task GetBankAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetBankAsync(banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetBanksAsync()
        {
            var result = await _client.GetBanksAsync().ConfigureAwait(false);
            Assert.NotEmpty(result);
        }

        [Fact]
        public async Task GetCreditLimitOrderRequestsAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var customers = await _client.GetCustomersForCurrentUserAsync().ConfigureAwait(false);
            //TODO: cleanup
            // ReSharper disable once SuggestVarOrType_BuiltInTypes
            var result = await _client.GetCreditLimitOrderRequestsAsync(banks.First().Id, customers.First().CustomerId).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetTransactionTypesAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var result = await _client.GetTransactionTypesAsync(banks.First().Id).ConfigureAwait(false);
            Assert.NotNull(result);
        }

        [Fact]
        public async Task GetCreditCardOrderStatusAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            var customers = await _client.GetCustomersForCurrentUserAsync().ConfigureAwait(false);
            //var result = await _client.GetCreditCardOrderStatusAsync(banks.Banks.First().Id, customers.Customers.First().CustomerId, );
            //Assert.NotNull(result);
        }

        [Fact]
        public async Task GetCheckbookOrdersAsync()
        {
            var banks = await _client.GetBanksAsync().ConfigureAwait(false);
            //var result = await _client.GetCheckbookOrdersAsync(banks.Banks.First().Id, );
            //Assert.NotNull(result);
        }
    }
}
