using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Markup;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MySqlConnector;
using SciResearchHub.Models;
using SciResearchHub.Services;

namespace SciResearchHub.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public ResearchExtractService Researchservice;
        public List<string> values = new List<string>();
        public List<Research> researches { get; private set; }

        public PrivacyModel(ILogger<PrivacyModel> logger,
            ResearchExtractService researchservice)
        {
            _logger = logger;
            Researchservice = researchservice;

        }

        public void OnGet()
        {
            researches =  Researchservice.GetResearches();
            
        }
    }
}
