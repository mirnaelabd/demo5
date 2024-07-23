using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo5.abstraction
{
    internal abstract class shape
    {
        public decimal D01 { get; set; }
        public decimal D02 { get; set; }
        public abstract decimal perimter  { get;}

        public abstract decimal CALCAREA();


    }

    internal abstract class rectbase : shape
    {
      

        public override decimal CALCAREA()
        {
            return D01* D02;
        }
    }


}
