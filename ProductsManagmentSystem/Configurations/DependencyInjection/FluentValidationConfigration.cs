﻿namespace ProductsMangementSystem.Configurations.DependencyInjection
{
    public static class FluentValidationConfigration
    {
        public static IServiceCollection AddFluentValidation(this IServiceCollection services, Assembly assembly)
        {
            services.AddValidatorsFromAssembly(assembly);
            return services;
        }
    }
}
