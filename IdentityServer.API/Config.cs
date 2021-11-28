// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.


using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer.API
{
    public static class Config
    {

        public static IEnumerable<ApiScope> GetApiScopes()
        {
            return new List<ApiScope>
            {
                new ApiScope("BankOfChina.Write","BankOfChina Write Permission"),
                new ApiScope("BankOfChina.Read","BankOfChina Read Permission"),
                new ApiScope("YapıKredi.Write","YapıKredi Write Permission"),
                new ApiScope("YapıKredi.Read","YapıKredi Read Permission"),
            };
        }

        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("BankOfChina"){ Scopes = { "BankOfChina.Write", "BankOfChina.Read" } },
                new ApiResource("YapıKredi"){ Scopes = { "YapıKredi.Write", "YapıKredi.Read" } }
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client
                {
                    ClientId = "Bank Of China",
                    ClientName = "Bank Of China",
                    ClientSecrets = { 
                        new Secret("BankOfChina".Sha256())
                    },
                    AllowedGrantTypes = { 
                        GrantType.ClientCredentials
                    },
                    AllowedScopes = { "BankOfChina.Write", "BankOfChina.Read" }
                },
                new Client
                {
                    ClientId = "Yapı Kredi Bankası",
                    ClientName = "Yapı Kredi Bankası",
                    ClientSecrets = { 
                        new Secret("YapıKredi".Sha256())
                    },
                    AllowedGrantTypes = { 
                        GrantType.ClientCredentials
                    },
                    AllowedScopes = { "YapıKredi.Write", "YapıKredi.Read" }
                }
            };
        }
    }
}