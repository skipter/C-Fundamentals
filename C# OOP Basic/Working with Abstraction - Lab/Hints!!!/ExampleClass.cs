using System;
using System.Collections.Generic;
using System.Text;

namespace Hints___
{
    public class ExampleClass
    {

        private readonly int number = 8;   //This is field     //only way to intial number is here or in constructor

        private void Test()
        {
           // number = 5; -> throw exception/error
        }


        //Prop definition

        //THIS IS AUTO PROPERTY
        //propfull tab tab
        //All prop must be inital, here or in the constructor
        private int myVar = 0; //can initial value

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }


        public int MyProp { get; set; } = 0;

        public List<int> Numbers { get; set; }

        //Constructors
        public ExampleClass()
        {
            Numbers = new List<int>();
        }

        public ExampleClass(int number) : this()        //This means that this() will call the empty constructor
        {                                               //This is chaining.
            Numbers.Add(number);
        }

        public ExampleClass(int number, int myProperty) : this(number)
        {
            MyProperty = myProperty;                    //Chaining - call first ExampleClass, then ExampleClass with int number and then that last constructor
        }

    }
}
