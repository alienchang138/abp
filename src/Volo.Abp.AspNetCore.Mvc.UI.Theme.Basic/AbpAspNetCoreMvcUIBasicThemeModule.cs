﻿using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic
{
    [DependsOn(
        typeof(AbpAspNetCoreMvcUiBootstrapModule)
        )]
    public class AbpAspNetCoreMvcUiBasicThemeModule : AbpModule
    {
        public override void ConfigureServices(IServiceCollection services)
        {
            services.Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<AbpAspNetCoreMvcUiBasicThemeModule>("Volo.Abp.AspNetCore.Mvc.UI.Theme.Basic");
            });

            services.AddAssemblyOf<AbpAspNetCoreMvcUiBasicThemeModule>();
        }
    }
}
