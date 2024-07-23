using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo5.abstraction
{
    internal class rectangle : rectbase
    {
        public override decimal perimter
        {
            get { return (D01 + D02) * 2; }
        }

  
    }
}
