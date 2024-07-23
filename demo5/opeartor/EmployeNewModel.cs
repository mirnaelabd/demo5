using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo5.opeartor
{

    //view 
    internal class EmployeNewModel
    {
        public string? Fisrt_Name { get; set; }
        public string? Last_Name { get; set; }
        public string? Email { get; set; }
        #region casting 

        public static explicit operator  EmployeNewModel (Employee employe)
        {
            String[]? names = employe?.Name?.Split(" ");
            return new EmployeNewModel()
            {
                Email = employe?.Email ?? string.Empty,
                Fisrt_Name = names.Length > 0 ? names[0] : string.Empty,
                Last_Name = names.Length > 1 ? names[1] : string.Empty,

            };
        }
        #endregion


    }
}
