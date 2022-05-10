using System;

namespace Class
{
    class MyClass
    {
        public MyClass()
        {

        }

        public string myField = string.Empty;

        public void MyMethod(int parameter1, string parameter2)
        {
            Console.WriteLine("First Parameter {0}, second Parameter {1}", parameter1,parameter2);
        }

        public int MyAutoImplementedProperty { get; set; }

        private int MyPropertyVar;

        public int MyProperty
        {
            get { return MyPropertyVar / 2; }

            set
            {
                if(MyPropertyVar > 100)
                {
                    MyPropertyVar = 100;
                }
                else
                {
                    MyPropertyVar = value;
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
