using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using Sniper.Application.Messages;
using Sniper.Authentication;
using Sniper.Configuration;
using static Sniper.WarningsErrors.MessageSuppression;

namespace Sniper
{
    internal class AccessTokenAuthenticator : TokenAuthenticatorBase
    {
        public AccessTokenAuthenticator()
        {
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage(Categories.Globalization, MessageAttributes.SpecifyIFormatProvider)]
        public AccessTokenAuthenticator(IRestfulData restful)
        {
            using (var client = new WebClient())
            {
                client.BaseAddress = restful.ApiUrl;
                client.Encoding = Encoding.UTF8;
                client.Credentials = new NetworkCredential(restful.UserName, restful.Password);
                var result = client.DownloadString(Path.Combine(client.BaseAddress, "UserStories"));
                if (result.Length == 0) throw new InvalidDataException();
               
            }
        }
    }
}
