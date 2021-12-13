using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week14Lab
{
    class rectangle
    {
        static void Main(string[] args)
        {
            //A delegate is an object which refers to a method or you can say it is a reference type variable that can hold a reference to the methods. 
            //Delegates in C# are similar to the function pointer in C/C++. 
            //It provides a way which tells which method is to be called when an event is triggered.
            // 
            // creating object of class  
            // "rectangle", named as "rect" 
            rectangle rect = new rectangle();

            // these two lines are normal calling 
            // of that two methods 
            // rect.area(6.3, 4.2); 
            // rect.perimeter(6.3, 4.2); 

            // creating delegate object, name as "rectdele" 
            // and pass the method as parameter by  
            // class object "rect" 
            rectDelegate rectdele = new rectDelegate(rect.area);

            // also can be written as  
            // rectDelegate rectdele = rect.area; 

            // call 2nd method "perimeter" 
            // Multicasting 
            //rectdele += rect.perimeter;
            rectdele = rectdele + new rectDelegate(rect.perimeter);

            // pass the values in two method  
            // by using "Invoke" method 
            rectdele.Invoke(6.3, 4.2);
            Console.WriteLine();

            // call the methods with  
            // different values 
            rectdele.Invoke(16.3, 10.3);

            Console.ReadLine();
        }

        // declaring delegate 
        public delegate void rectDelegate(double height, double width);

        //"area" method
        public void area(double height, double width)
        {
            Console.WriteLine("Area is: {0}", (width * height));
        }

        //"perimeter" method
        public void perimeter(double height, double width)
        {
            Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
        }

       
    }
}
