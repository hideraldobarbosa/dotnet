using Microsoft.Extensions.DependencyInjection;
using AspNetCoreIdentity.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreIdentity.Config
{
    public static class IdentityConfig
    {
        public static IServiceCollection AddAuthorizationConfig(this IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                options.AddPolicy("PodeExcluir", policy =>
                    policy.RequireClaim("PodeExcluir"));

                options.AddPolicy("PodeLer", policy => policy.Requirements
                 .Add(new PermissaoNecessaria(permissao: "PodeLer")));

                options.AddPolicy("PodeEscrever", policy => policy.Requirements
                  .Add(new PermissaoNecessaria(permissao: "PodeEscrever")));

            });
            return services;
        }

    }
}
