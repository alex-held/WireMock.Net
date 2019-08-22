﻿using HandlebarsDotNet;
using JetBrains.Annotations;
using System;
using WireMock.Handlers;
using WireMock.Logging;

namespace WireMock.Settings
{
    /// <summary>
    /// IWireMockServerSettings
    /// </summary>
    public interface IWireMockServerSettings
    {
        /// <summary>
        /// Gets or sets the port.
        /// </summary>
        [PublicAPI]
        int? Port { get; }

        /// <summary>
        /// Gets or sets the use SSL.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        [PublicAPI]
        bool? UseSSL { get; }

        /// <summary>
        /// Gets or sets whether to start admin interface.
        /// </summary>
        [PublicAPI]
        bool? StartAdminInterface { get; }

        /// <summary>
        /// Gets or sets if the static mappings should be read at startup.
        /// </summary>
        [PublicAPI]
        bool? ReadStaticMappings { get; }

        /// <summary>
        /// Watch the static mapping files + folder for changes when running.
        /// </summary>
        [PublicAPI]
        bool? WatchStaticMappings { get; }

        /// <summary>
        /// Gets or sets if the proxy and record settings.
        /// </summary>
        [PublicAPI]
        IProxyAndRecordSettings ProxyAndRecordSettings { get; }

        /// <summary>
        /// Gets or sets the urls.
        /// </summary>
        [PublicAPI]
        string[] Urls { get; }

        /// <summary>
        /// StartTimeout
        /// </summary>
        [PublicAPI]
        int StartTimeout { get; }

        /// <summary>
        /// Allow Partial Mapping (default set to false).
        /// </summary>
        [PublicAPI]
        bool? AllowPartialMapping { get; }

        /// <summary>
        /// The username needed for __admin access.
        /// </summary>
        [PublicAPI]
        string AdminUsername { get; }

        /// <summary>
        /// The password needed for __admin access.
        /// </summary>
        [PublicAPI]
        string AdminPassword { get; }

        /// <summary>
        /// The RequestLog expiration in hours (optional).
        /// </summary>
        [PublicAPI]
        int? RequestLogExpirationDuration { get; }

        /// <summary>
        /// The MaxRequestLog count (optional).
        /// </summary>
        [PublicAPI]
        int? MaxRequestLogCount { get; }

        /// <summary>
        /// Action which is called (with the IAppBuilder or IApplicationBuilder) before the internal WireMockMiddleware is initialized. [Optional]
        /// </summary>
        [PublicAPI]
        Action<object> PreWireMockMiddlewareInit { get; set; }

        /// <summary>
        /// Action which is called (with the IAppBuilder or IApplicationBuilder) after the internal WireMockMiddleware is initialized. [Optional]
        /// </summary>
        [PublicAPI]
        Action<object> PostWireMockMiddlewareInit { get; set; }

        /// <summary>
        /// The IWireMockLogger which logs Debug, Info, Warning or Error
        /// </summary>
        [PublicAPI]
        IWireMockLogger Logger { get; set; }

        /// <summary>
        /// Handler to interact with the file system to read and write static mapping files.
        /// </summary>
        [PublicAPI]
        IFileSystemHandler FileSystemHandler { get; set; }

        /// <summary>
        /// Action which can be used to add additional is Handlebar registrations. [Optional]
        /// </summary>
        [PublicAPI]
        Action<IHandlebars, IFileSystemHandler> HandlebarsRegistrationCallback { get;  }
    }
}