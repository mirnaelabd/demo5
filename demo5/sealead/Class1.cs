using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace demo5.sealead
{
    internal class parent
    {

        private   int salary;

        public virtual int Salary
        {
            get { return salary; }
            set { salary = value +1000; }
        }

        public virtual void print()
        {

            Console.WriteLine("i am parent");
        }
    }
    internal class child :parent
    {
        public sealed override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value < 5000 ? 5000 :value; }
        }

        public sealed override void print()
        {
            Console.WriteLine("i am child");
        }
    }
    internal class grandchild
    {
        public new void print()
        {
            Console.WriteLine("grandchild");
        }
    }

}
