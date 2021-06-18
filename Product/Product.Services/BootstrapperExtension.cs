﻿using Microsoft.Extensions.DependencyInjection;
using Product.DAL;
using Product.Services.ProductionMonitoring;

namespace Product.Services
{
    public static class BootstrapperExtension
    {
        public static void RegisterServicesFactory(this IServiceCollection service)
        {
            service.RegisterDataAccessLayerServices();

            service.AddScoped<IProductionMonitoringService, ProductionMonitoringService>();
        }
    }
}
