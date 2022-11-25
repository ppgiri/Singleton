using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonConsoleApp
{
    //singleton design pattern
    //In this pattern, a class has only one instance in the program that provides a global point of access to it.
    //a singleton is a class that allows only a single instance of itself to be created and usually gives simple access to that instance.
    //Private and parameterless single constructor
    //Sealed class.
    //Static variable to hold a reference to the single created instance
    //A public and static way of getting the reference to the created instance.

    public class Singleton
    {
        private static Singleton _instance;     //Static property with have private keyword



        private Singleton()      //Private constructor
        {
        }


        public static Singleton Instance   //Public static property & return insatnce
        {
            get
            {
                if (_instance == null)
                    _instance = new Singleton();



                return _instance;
            }
        }


        public void DoSingletonOperation()    //non static public method for singleton opeartion
        {
            Console.WriteLine("singleton operation");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Singleton singleton = Singleton.Instance;



            Singleton singleton2 = Singleton.Instance;



            Console.WriteLine(singleton == singleton2);
            Console.ReadLine();


        }
    }
}
