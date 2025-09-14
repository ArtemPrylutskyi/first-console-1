using System;

namespace SecondTaskApp
{
    public class MyClass
    
        private string _secret = "This is private field";

        public string Name { get; set; }

        public MyClass()
        {
            Name = "No Name";
        }

        public MyClass(string name)
        {
            Name = name;
        }


        public void PrintInfo()
        {
            Console.WriteLine("Object name: " + Name);
            ShowSecret();
        }

        private void ShowSecret()
        {
            Console.WriteLine("Secret: " + _secret);
        }
    }
}
