using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Tour_Managament_EAD_project.Models;

namespace Tour_Managament_EAD_project.Services
{
    public class JasonfilePlacesService
    {
        //Gets or sets the absolute path to the directory that contains the web-servable application content files.

        public IWebHostEnvironment WebHostEnvironment { get; set; }

        public string JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "places.json");

            }
        }

        public object JsonConvert { get; private set; }

        public JasonfilePlacesService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IEnumerable<Places> getPlaces()
        {
            using (var json_file = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<Places[]>(json_file.ReadToEnd());
            }

        }

    }
}
