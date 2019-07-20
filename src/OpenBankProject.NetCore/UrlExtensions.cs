using Flurl;
using Flurl.Http;

namespace OpenBankProject.NetCore
{
    public static class UrlExtensions
    {
        public static IFlurlRequest WithDirectLoginToken(this Url url, string token) => 
            url.WithHeader("Authorization", $"DirectLogin token=\"{token}\"");
    }
}
