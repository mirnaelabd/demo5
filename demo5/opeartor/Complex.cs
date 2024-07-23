using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace demo5.opeartor
{
    internal class com
    {
        public int Real { get; set; }   
        public int imagine { get; set; }

        public override string ToString()
        {
            return $"{Real}+{imagine}i"; 
        }

        #region opeartor Overloading 
        // + 
        // non - private , class member method
        // 
        public static com operator + (com left, com right)
        {
            return new com()
            {
                Real = (left?.Real?? 0) + (right?.Real?? 0), 
                imagine = (left?.imagine?? 0) + (right?.imagine?? 0)  
             
            };

        }

        public static com operator -(com left, com right)
        {
            return new com()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                imagine = (left?.imagine ?? 0) - (right?.imagine ?? 0)

            };
        }

        public static com operator ++(com c)
        {
            return new com()
            {
                Real = (c?.Real ?? 0) + 1,
                imagine = c?.imagine ?? 0

            };
        }
        public static bool operator >(com left, com right)
        {
            if (left.Real == right.Real)
                return left.imagine > right.imagine;
            else
                return left.Real > right.Real;

        }
        public static bool operator <(com left, com right)
        {
            if (left.Real == right.Real)
                return left.imagine < right.imagine;
            else
                return left.Real < right.Real;

        }
        #endregion

        #region casting overloading 
         
        // int 
        public static /*int*/  explicit operator int (com c)
        {
            return c?.Real??0;
        }
        public static  implicit operator string (com c)
        {
            return c?.ToString()?? string.Empty; 
        }
        #endregion




    }
}
