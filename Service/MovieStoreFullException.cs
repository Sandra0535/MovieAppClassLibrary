using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppClassLibrary
{
    public class MovieStoreFullException:Exception
    {
        public MovieStoreFullException(string message) : base(message) { }
    }
}
