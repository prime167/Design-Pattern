﻿using System;

namespace FactoryPattern
{
    public abstract class AbstractBus
    {
        protected abstract void DoOperation();

        public void GetInfo()
        {
            Console.WriteLine($"I am {this.GetType().Name}.");
        }
    }

    public class ConcreteBusA : AbstractBus
    {

        protected override void DoOperation()
        {

            throw new System.NotImplementedException();
        }
    }

    public class ConcreteBusB : AbstractBus
    {
        protected override void DoOperation()
        {
            throw new System.NotImplementedException();
        }
    }
}