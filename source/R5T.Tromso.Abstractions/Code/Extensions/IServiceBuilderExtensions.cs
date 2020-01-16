﻿using System;

using Microsoft.Extensions.Configuration;


namespace R5T.Tromso
{
    public static class IServiceBuilderExtensions
    {
        /// <summary>
        /// Allows for configure configuration actions that require no services to be added to a <see cref="IServiceBuilder"/>.
        /// </summary>
        public static void AddConfigureConfiguration(this IServiceBuilder serviceBuilder, Action<IConfigurationBuilder> configureConfigurationAction)
        {
            serviceBuilder.AddConfigureConfiguration((configurationBuilder, _) => configureConfigurationAction(configurationBuilder));
        }
    }
}
