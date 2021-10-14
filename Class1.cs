using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Demo_Collection
{
    class Class1
    {

    }
    interface CarComparision<T>
    {
        string Name;
        public DisplayResults();
        public void Message()
        {
            Console.WriteLine("This msg is coming from the Interface");
        }
            
    }
    public static class Car:Car<car>
    {
        string CarModel { get; set; }
        string ModelName { get; set; }

        public Boolean Equals(Car,car)
        {
            Console.WriteLine("inside the car model");
        }
    }


}


    
        
