using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SciResearchHub.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SciResearchHub.Models;
using MySqlConnector;

namespace SciResearchHub.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public ResearchExtractService ResearchService;
        public IndexModel(ILogger<IndexModel> logger,
            ResearchExtractService researchService)
        {
            _logger = logger;
            ResearchService = researchService;
        }
        public List<Research> researches { get; private set; }
        public void OnGet()
        {
            researches = ResearchService.GetResearches();
        }
    }

}
