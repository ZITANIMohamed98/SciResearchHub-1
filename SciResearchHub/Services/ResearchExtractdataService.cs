using Microsoft.AspNetCore.Hosting;
using MySqlConnector;
using SciResearchHub.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
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
        public List<Research> Researches { get; private set; }
        public IWebHostEnvironment WebHostEnvironment { get; }
        

        public List<Research> GetResearches()
        {
                
                using var connection = new MySqlConnection("server=localhost;user=root;password=GrOwUP$$20;database=sciresearchhubdata");
                try
                {
                    connection.Open();
                    using var command = new MySqlCommand("SELECT * FROM Researches;", connection);
                    using var reader = command.ExecuteReader(CommandBehavior.SingleResult);
                    List<Research> researches = new List<Research>();
                    while (reader.Read())
                    {
                        Research research = new Research();
                        research.Id = reader["ResearchId"].ToString();
                        research.Title = reader["Title"].ToString();
                        research.Author = reader["Author"].ToString();
                        research.Domain = reader["Domain"].ToString();
                        research.Imglink = reader["Imglink"].ToString();
                        research.Link = reader["Link"].ToString();
                        research.DateCreated = reader["DateCreated"].ToString();
                        researches.Add(research);
                    }
                    return researches;
                }
                finally
                {
                    connection.Close();
                }
            
        }
    }
}
