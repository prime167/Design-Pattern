﻿using System;
using System.Threading;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("单例模式：");
            TestStaticSingleton();
            TestLasyInitialSingleton();
            TestGenericSingleton();
            TestDoubleLockSingleton();
        }

        private static void TestStaticSingleton()
        {
            Console.WriteLine("静态变量初始化实例");

            Singleton1 singleton1 = Singleton1.Instance();
            singleton1.GetInfo();

            Console.ReadLine();
        }

        private static void TestLasyInitialSingleton()
        {
            Console.WriteLine("延迟初始化实例");

            Singleton2 singleton2 = Singleton2.Instance();
            singleton2.GetInfo();
            singleton2.Reset();
           
            Console.ReadLine();
        }

        private static void TestDoubleLockSingleton()
        {
            Console.WriteLine("锁机制确保多线程只产生一个实例");

            for (int i = 0; i < 2; i++)
            {
                Thread thread=new Thread(ExecuteInForeground);

                thread.Start();
            }
        }


        private static void ExecuteInForeground()
        {
            Console.WriteLine("Thread {0}: {1}, Priority {2}",
                              Thread.CurrentThread.ManagedThreadId,
                              Thread.CurrentThread.ThreadState,
                              Thread.CurrentThread.Priority);

            Singleton3 singleton3 =Singleton3.Instance();
            singleton3.GetInfo();
            Console.WriteLine(singleton3.GetHashCode());
        }

        private static void TestGenericSingleton()
        {
            Console.WriteLine("泛型单例模式：");

            Singleton4 instance = GenericSingleton<Singleton4>.GetInstance();

            instance.GetInfo();

            var singleton4 = Singleton4.Instance;

            singleton4.GetInfo();
            Console.ReadLine();
        }
    }
}
