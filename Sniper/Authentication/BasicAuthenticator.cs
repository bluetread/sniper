using System.Collections.Generic;
using Sniper.Http;
using ICredentials = Sniper.Http.ICredentials;

namespace Sniper
{
    internal class BasicAuthenticator : BaseAuthenticator
    {
        protected override Dictionary<string, string> DefaultQueryParameters => new Dictionary<string, string>
        {
            { ResponseFormatParameter.Key, ResponseFormatParameter.Value } 
        };

        public BasicAuthenticator() {}

        public BasicAuthenticator(IApiSiteInfo apiSiteInfo, ICredentials credentials) : base(apiSiteInfo, credentials) {}

#if false
        ///<summary>
        ///Authenticate a request using the basic access authentication scheme
        ///</summary>
        ///<param name="apiSiteInfo">The request to authenticate</param>
        ///<param name="credentials">The credentials to attach to the request</param>
        ///<remarks>
        ///See the <a href="https://dev.targetprocess.com/docs/authentication#section-basic-authentication">Basic Authentication documentation</a> for more information. 
        ///</remarks>
        public override void Authenticate(IApiSiteInfo apiSiteInfo, ICredentials credentials)
        {
            Ensure.ArgumentNotNull(nameof(apiSiteInfo), apiSiteInfo);
            Ensure.ArgumentNotNull(nameof(credentials), credentials);
            Ensure.ArgumentNotNull(nameof(credentials.Login), credentials.Login);
            Ensure.ArgumentNotNull(nameof(credentials.Password), credentials.Password);
            Ensure.ArgumentNotNull(nameof(apiSiteInfo.Route), apiSiteInfo.Route);

            using (var client = new WebClient())
            {
                var address = ApiSiteHelpers.BuildUri(
                    new Collection<string>
                    {
                        apiSiteInfo.ApiUrl,
                        apiSiteInfo.Route,
                    }
                , apiSiteInfo.Parameters);
                client.Encoding = Encoding.UTF8;
                client.Credentials = new NetworkCredential(credentials.Login, credentials.Password);
                try
                {
                    var result = client.DownloadString(address);
                    if (result.Length == 0) throw new InvalidDataException();
                    //TODO

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }
#endif
    }
}
