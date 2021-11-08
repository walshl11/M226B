using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Classes
{
    public class Movie
    {
        public string Title { get; set; }

        public IEnumerable<Actor> Cast { get; set; }

        public void AddActor(Actor actor)
        {
            Cast.ToList().Add(actor);
        }

        public Movie()
        {
            Title = "shit";
            Cast = new List<Actor>();
        }
    }
}
