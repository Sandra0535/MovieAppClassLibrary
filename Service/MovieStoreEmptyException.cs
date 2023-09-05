using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppClassLibrary
{
    public class MovieStoreEmptyException:Exception
    {
        public MovieStoreEmptyException(string message):base(message) { }
    }
}
