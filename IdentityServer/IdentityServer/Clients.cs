using System.Collections.Generic;
using IdentityServer3.Core.Models;

namespace IdentityServer
{
    public static class Clients
    {
        public static IEnumerable<Client> Get()
        {
            return new[]
            {
                new Client
                {
                    Enabled = true,
                    ClientName = "JS Client",
                    ClientId = "js",
                    Flow = Flows.Implicit,

                    RedirectUris = new List<string>
                    {
                        "http://localhost:51599/popup.html"
                    },

                    AllowedCorsOrigins = new List<string>
                    {
                        "http://localhost:51599/"
                    },

                    PostLogoutRedirectUris = new List<string>
                    {
                        "http://localhost:51599/index.html"
                    },
                    AllowAccessToAllScopes = true,
                    AccessTokenLifetime = 70
                }
            };
        }
    }
}