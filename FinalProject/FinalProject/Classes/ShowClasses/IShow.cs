using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Classes.ShowClasses
{
    public interface IShow
    {
        string ID { get; set; }
        string Name { get; set; }
        string ReleaseDate { get; set; }
        bool HaveWatched { get; set; }
        string ImageUrl { get; set; }

    }
}
