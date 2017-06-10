﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Threading.Tasks;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace Microsoft.AspNetCore.Identity.Service.Configuration
{
    public interface IConfigurationMetadataProvider
    {
        int Order { get; }

        Task ConfigureMetadataAsync(OpenIdConnectConfiguration configuration, ConfigurationContext context);
    }
}