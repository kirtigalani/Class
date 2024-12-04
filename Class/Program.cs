using System;


    class Customer
    {
        string _first;
        string _last;

        public void customer(string firstName, string lastName)
        {
            this._first = firstName;
            this._last = lastName;
        }
        public void print()
        {
            Console.WriteLine("Full name {0} ", this._first+" "+ this._last);
        }
        ~Customer()
        {
            //clean up code
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer("Hello", "world");
            c1.print();
        }
    }
