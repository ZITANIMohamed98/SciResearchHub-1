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

namespace SciResearchHub.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public List<object> values { get; set; } = new List<object>();
        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
          
            using var connection = new MySqlConnection("server=localhost;user=root;password=GrOwUP$$20;database=sciresearchhubdata");
            await connection.OpenAsync();
            using var command = new MySqlCommand("SELECT Title FROM Researches;", connection);
            using var reader = await command.ExecuteReaderAsync();
            
            while (await reader.ReadAsync())
            {
                   values.Add(reader.GetValue(0));
            }
        }
    }
}
