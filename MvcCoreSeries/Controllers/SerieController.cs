using Microsoft.AspNetCore.Mvc;
using MvcCoreSeries.Models;
using MvcCoreSeries.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreSeries.Controllers
{
    public class SerieController : Controller
    {
        private RepositorySeries repo;
        public SerieController(RepositorySeries repo) 
        {
            this.repo = repo;
        }
        public IActionResult Details(int idserie)
        {
            
            Serie serie = this.repo.FindSerie(idserie);
            return View(serie);
        }
    }
}
