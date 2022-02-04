using MvcCoreSeries.Data;
using MvcCoreSeries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreSeries.Repositories
{
    public class RepositorySeries
    {
        private SerieContext context;
        public RepositorySeries(SerieContext context) 
        {
            this.context = context;
        }

        public List<Serie> GetSeries() 
        {
            var consulta = from datos in this.context.Series
                           select datos;
            return consulta.ToList();
        }

        public Serie FindSerie(int id) 
        {
            var consulta = from datos in this.context.Series
                           where datos.IdSerie == id
                           select datos;

            return consulta.FirstOrDefault();
        }
    }
}
