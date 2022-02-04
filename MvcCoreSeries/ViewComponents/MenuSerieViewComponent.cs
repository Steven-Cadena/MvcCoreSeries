using Microsoft.AspNetCore.Mvc;
using MvcCoreSeries.Models;
using MvcCoreSeries.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreSeries.ViewComponents
{
    /*importante la herencia de viewcomponent*/
    /*invokeasync está hecho para solamente al layout*/
    public class MenuSerieViewComponent:ViewComponent
    {
        private RepositorySeries repo;
        public MenuSerieViewComponent(RepositorySeries repo) 
        {
            this.repo = repo;
        }
        //AQUI PODEMOS TENER CUALQUIER CODIGO COMO HERRAMIENTA 
        //OBLIGATORIO TENER EL METODO InvokeAsync QUE SERA EL 
        //QUE LLAMAREMOS DESDE EL LAYOUT 
        //ESTE METODO CARGARA UN MODEL EN UNA VISTA PARA EL LAYOUT
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Serie> series = this.repo.GetSeries();
            return View(series);
        }
    }
}
