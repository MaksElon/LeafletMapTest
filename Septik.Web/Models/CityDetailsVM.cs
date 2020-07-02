using Septik.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Septik.Web.Models
{
    public class CityDetailsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public List<CityImage> CityImages { get; set; }
    }
}
