using Microsoft.AspNetCore.Hosting;
using MySqlConnector;
using SciResearchHub.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace SciResearchHub.Services
{
    public class ResearchExtractService

    {
        public ResearchExtractService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }
        public List<Research> Researches { get; set; } = new List<Research>();
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "App-data", "Researches.json"); }
        }

        public async Task GetProductsAsync()
        {
            
            
        }

    }
}
