﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Castle.DynamicProxy;
using Volo.Abp.Modularity;

namespace Volo.Abp.Castle
{
    [DependsOn(typeof(AbpCommonModule))]
    public class AbpCastleCoreModule : AbpModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(typeof(CastleAbpInterceptorAdapter<>));
        }
    }
}
