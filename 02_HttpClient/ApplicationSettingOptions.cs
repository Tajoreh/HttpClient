﻿using Microsoft.Extensions.Options;

namespace _02_HttpClient;

public class ApplicationSettingOptions : IConfigureOptions<ApplicationSettings>
{
    IConfiguration _configuration;

    public ApplicationSettingOptions(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void Configure(ApplicationSettings options)
    {
        _configuration.GetSection(nameof(ApplicationSettings)).Bind(options);
    }
}