using System;

namespace FactoryPattern
{
    public abstract class AbstractCar
    {
        protected abstract void DoOperation();

        public void GetInfo()
        {
            Console.WriteLine($"I am {this.GetType().Name}.");
        }
    }

    public class ConcreteCarA : AbstractCar
    {

        protected override void DoOperation()
        {
            
            throw new System.NotImplementedException();
        }
    }

    public class ConcreteCarB : AbstractCar
    {
        protected override void DoOperation()
        {
            throw new System.NotImplementedException();
        }
    }
}
