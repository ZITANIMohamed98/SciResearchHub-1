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
        public List<Research> Researches { get; set; } = new List<Research>();
        public IndexModel(ILogger<IndexModel> logger,
            ResearchExtractService researchService)
        {
            _logger = logger;
            ResearchService = researchService;
        }

        public async Task OnGetAsync()
        {
            using var connection = new MySqlConnection("server=localhost;user=root;password=GrOwUP$$20;database=sciresearchhubdata");
            await connection.OpenAsync();
            using var id = new MySqlCommand("SELECT ResearchId FROM Researches;", connection);
            using var title = new MySqlCommand("SELECT Title FROM Researches;", connection);
            using var author = new MySqlCommand("SELECT Author FROM Researches;", connection);
            using var domain = new MySqlCommand("SELECT Domain FROM Researches;", connection);
            using var imglink = new MySqlCommand("SELECT Imglink FROM Researches;", connection);
            using var link = new MySqlCommand("SELECT Link FROM Researches;", connection);
            using var dateCreated = new MySqlCommand("Select DateCreated FROM Researches;", connection);
            using var length = new MySqlCommand("Select COUNT(Id) FROM Researches;", connection);

            using var idreader = await id.ExecuteReaderAsync();
            using var titlereader = await title.ExecuteReaderAsync();
            using var authorreader = await author.ExecuteReaderAsync();
            using var domainreader = await domain.ExecuteReaderAsync();
            using var imglinkreader = await imglink.ExecuteReaderAsync();
            using var linkreader = await link.ExecuteReaderAsync();
            using var dateCreatedreader = await dateCreated.ExecuteReaderAsync();
            using var lengthreader = await length.ExecuteReaderAsync();
            while (await idreader.ReadAsync())
            {
                Research research = new Research(idreader.GetValue(0), titlereader.GetValue(0), authorreader.GetValue(0), domainreader.GetValue(0), imglinkreader.GetValue(0), linkreader.GetValue(0), dateCreatedreader.GetValue(0));
                Researches.Add(research);
            }
        }
    }
}
