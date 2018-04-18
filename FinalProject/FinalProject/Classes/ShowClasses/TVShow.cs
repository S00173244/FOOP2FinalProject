using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes.ShowClasses
{
    public class TVShow : IShow
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string ReleaseDate { get; set; }
        public bool HaveWatched { get; set; }
        public string ImageUrl { get; set; }
    }
}
