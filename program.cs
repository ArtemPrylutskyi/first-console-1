using System;

namespace ThirdTaskApp
{
    
    public interface IGenericInterface<T>
    {
        T GenericMethod(T value);
    }

  
    public interface INormalInterface
    {
        void NormalMethod();
    }

    
    public abstract class MyAbstractClass
    {
        
        public abstract void AbstractMethod();

       
        public void RegularMethod()
        {
            Console.WriteLine("Це звичайний метод з абстрактного класу");
        }
    }

    public class MyClass : MyAbstractClass, IGenericInterface<string>, INormalInterface
    {
        public string GenericMethod(string value)
        {
            return $"GenericMethod отримав: {value}";
        }

        
        public void NormalMethod()
        {
            Console.WriteLine("realization NormalMethod");
        }

        
        public override void AbstractMethod()
        {
            Console.WriteLine("realization AbstractMethod");
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            obj.AbstractMethod();              
            obj.RegularMethod();             
            obj.NormalMethod();               
            Console.WriteLine(obj.GenericMethod("hello")); 
        }
    }
}
