﻿// <copyright file="AppSettings.cs" company="WavePoint Co. Ltd.">
// Licensed under the MIT license. See LICENSE file in the samples root for full license information.
// </copyright>

namespace OnlineSales.Configuration;

public class BaseServiceConfig
{
    public string Server { get; set; } = string.Empty;

    public int Port { get; set; } = 0;

    public string UserName { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;
}

public class PostgresConfig : BaseServiceConfig
{
    public string Database { get; set; } = string.Empty;

    public string ConnectionString
    {
        get
        {
            return $"User ID={UserName};Password={Password};Server={Server};Port={Port};Database={Database};Pooling=true;";
        }
    }
}

public class ElasticSearchConfig : BaseServiceConfig
{
    public bool UseHttps { get; set; } = false;

    public string Url
    {
        get
        {
            return $"http{(UseHttps ? "s" : string.Empty)}://{Server}:{Port}";
        }
    }
}

public class SmtpServerConfig : BaseServiceConfig
{
    public bool UseTLS { get; set; } = false;
}

public class AppSettings
{
    public PostgresConfig Postgres { get; set; } = new PostgresConfig();

    public ElasticSearchConfig ElasticSearch { get; set; } = new ElasticSearchConfig();

    public SmtpServerConfig SmtpServer { get; set; } = new SmtpServerConfig();
}