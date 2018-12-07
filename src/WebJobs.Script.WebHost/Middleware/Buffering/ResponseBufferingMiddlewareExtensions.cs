// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Buffering;

namespace Microsoft.AspNetCore.Builder
{
    public static class ResponseBufferingMiddlewareExtensions
    {
        public static IApplicationBuilder UseResponseBuffering(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ResponseBufferingMiddleware>();
        }
    }
}
