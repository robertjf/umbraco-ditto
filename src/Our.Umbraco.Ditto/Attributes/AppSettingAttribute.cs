﻿namespace Our.Umbraco.Ditto
{
    using System;

    /// <summary>
    /// The Umbraco dictionary value attribute.
    /// Used for providing Umbraco with additional information about a dictionary item to aid property value conversion.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class AppSettingAttribute : DittoValueResolverAttribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppSettingAttribute"/> class.
        /// </summary>
        public AppSettingAttribute()
            : base(typeof(AppSettingValueResolver))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UmbracoDictionaryAttribute"/> class.
        /// </summary>
        /// <param name="appSettingKey">
        /// The app setting key in the web.config
        /// </param>
        public AppSettingAttribute(string appSettingKey)
            : base(typeof(AppSettingValueResolver))
        {
            this.AppSettingKey = appSettingKey;
        }

        /// <summary>
        /// Gets or sets the app setting key.
        /// </summary>
        public string AppSettingKey { get; set; }
    }
}