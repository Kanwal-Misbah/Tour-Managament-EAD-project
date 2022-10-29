using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour_Managament_EAD_project.Services;

namespace Tour_Managament_EAD_project.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IEnumerable<Models.Places> visiting_place { get; private  set; }
        public JasonfilePlacesService GetPlacesService;
        public IndexModel(ILogger<IndexModel> logger,
            JasonfilePlacesService placeService)
            
        {
            _logger = logger;
            GetPlacesService = placeService;
        }

        public void OnGet()
        {
            visiting_place= GetPlacesService.getPlaces();
        }
    }
}
