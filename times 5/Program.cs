using System;

namespace times
{
    class Program
    {


         
        

        //TODO impliment this ref method by returning  a string and mulitplying the parameter. So it will have two outputs but only returns the string.
        //TODO Call the method in the main and make sure the method changes the number of an initialized variable.
        public static string TimesFive(ref int x)
        {
            string result = $"{x} time 5 = {x * 5}";

            x *= 5;

            return result;
           
        }
        
        //TODO create method that uses the out keyword. Call the method in the main.
        public static string TimesTen(int y, out int x)
        {
            string result = $"{y} times 10 = {y * 10}";

            x = y * 10;

            return result;
        }
        static void Main(string[] args)
        {

            int y = 10;

            var stringResult = TimesFive(ref y);
            Console.WriteLine(y);
            Console.WriteLine(stringResult);

            int x;

            var stringTimesTen = TimesTen(2, out x);

            Console.WriteLine(x);

            Console.WriteLine(stringTimesTen);









        }

    }
}
