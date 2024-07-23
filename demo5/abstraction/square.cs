using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo5.abstraction
{
    internal class square : rectbase
    {
        public square(decimal D) {
            D01 = D02 = D; 

        }
        public override decimal perimter
        {
            get { return D02 * 4; }
        }

      
    }
}
