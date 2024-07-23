using demo5.abstraction;
using demo5.opeartor;
using demo5.partial;
using System.Security.Cryptography;


namespace demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region binary operator 
            /*   com complex1 = new com() { Real = 3, imagine = 2 };
               Console.WriteLine(complex1);
               com complex2 = new com() { Real = 5, imagine = 4 };
               Console.WriteLine(complex2);
              *//* com complex3 = complex + complex2;
               Console.WriteLine("///////////////////////////");
               Console.WriteLine(complex3);*//*
               com complex3 = complex1 - complex2;
               Console.WriteLine("///////////////////////////");
               Console.WriteLine(complex3);*/
            #endregion
            #region unary opreator 

            /*     complex3 = ++complex1; // perfix
                 Console.WriteLine(complex3);
                 complex3 = complex1++; // postfix
                 Console.WriteLine(complex3);*/

            #endregion
            #region relational opearotr 

            /*      if (complex1 > complex2)
                      Console.WriteLine("C1 is greater than c2");
                  else if (complex2 > complex1)
                      Console.WriteLine("c2 is greater than c1 "); */
            #endregion

            #region casting_overload
            /*      com c1 = new com() { Real=2 , imagine =3 };
                  int y = (int)c1;
                  string s = c1;  
                  Console.WriteLine(y);
                  Console.WriteLine(c1);
                  Console.WriteLine(s);*/
            #endregion

            #region Casting Operator Overloading

            /*   Employee employee = new Employee()
               {
                   Id = 1,
                   Name = "mirna elabd",
                   Email = "mirnaelabd0612@gmail.com",
                   Password = "12234",
                   SecrityStamp = Guid.NewGuid()
               }; 
               EmployeNewModel model = new EmployeNewModel();
               model = (EmployeNewModel)employee;

               Console.WriteLine(model.Fisrt_Name);
               Console.WriteLine(model.Last_Name);
   */
            #endregion

            #region abstract 
            /*      rectangle rectangle = new rectangle() { D01=10 , D02 =20 };

                  decimal Area = rectangle.CALCAREA(); 
                  Console.WriteLine(Area);
                  Console.WriteLine($"THE Premter {rectangle.perimter}");*/
            #endregion

            #region patial 
   /*         Emp emp = new Emp();
            emp.test = 1;
            emp.id = 34;
            emp.name= "test";
            emp.print();*/

        
            #endregion

        }
    }

}
