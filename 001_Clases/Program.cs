using System;

namespace Clases
{
    class MyClass
    {
        int _field;
        public int Field
        {set
            { _field = value; }
         get 
            { return _field; }
        }
       public  MyClass(int field)
        {
            _field = field;
        }
        public void Outpu()
        {
            Console.WriteLine(Field);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass(34);
            Console.WriteLine(m.Field);
            m.Outpu();
            Console.ReadKey();
        }
    }
}
