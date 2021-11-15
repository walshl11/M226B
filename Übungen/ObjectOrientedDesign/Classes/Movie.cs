using ObjectOrientedDesign.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedDesign.Classes
{
    public class Movie : IMovie
    {
        private string _title;
        private IEnumerable<IPerson> _cast;
        public Movie()
        {
            _cast = new List<IPerson>();
        }

        public void AddToCast(IPerson person)
        {
            _cast = _cast.Append(person);
        }

        public List<IPerson> GetCast()
        {
            return _cast.ToList();
        }

        public string GetName()
        {
            return _title;
        }

        public void SetName(string name)
        {
            _title = name;
        }
    }
}
