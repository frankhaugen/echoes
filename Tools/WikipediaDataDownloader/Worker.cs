using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Models.Enums;
using Models;
using Models.Wikipedia;
using RestSharp;

namespace WikipediaDataDownloader
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var currentDirectoryInfo = new DirectoryInfo(Environment.CurrentDirectory);
            var projectDirectoryInfo = currentDirectoryInfo?.Parent?.Parent;
            var outputDirectoryInfo = projectDirectoryInfo.CreateSubdirectory(Path.Combine("Alzheimer", "Assets", "Data"));
            var outputFileInfo = new FileInfo(Path.Combine(outputDirectoryInfo.FullName, "WikipediaSummaries.json"));
            
            _logger.LogInformation(outputFileInfo.FullName);

            var restClient = new RestClient();
            var output = new List<Models.KeyValuePair<ArticleName, Summary>>();
            foreach (var articleName in Enum.GetNames<ArticleName>())
            {
                var result = await restClient.GetAsync<Summary>(new RestRequest($"https://en.wikipedia.org/api/rest_v1/page/summary/{articleName}"), cancellationToken: stoppingToken);
                output.Add(new Models.KeyValuePair<ArticleName, Summary>() {Key = Enum.Parse<ArticleName>(articleName), Value = result });
            }

            if (outputFileInfo.Exists)
            {
                File.Delete(outputFileInfo.FullName);
            }

            await File.WriteAllTextAsync(outputFileInfo.FullName, JsonSerializer.Serialize(output, new JsonSerializerOptions() {WriteIndented = true}), stoppingToken);
        }
    }
}
