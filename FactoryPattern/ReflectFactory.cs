using System;

namespace FactoryPattern
{
    /// <summary>
    /// 反射工厂模式
    /// 是针对简单工厂模式的一种改进
    /// </summary>
    public static class ReflectFactory
    {
        public static AbstractCar Create(string typeName)
        {
            Type type = Type.GetType(typeName, true, true);
            var instance = type?.Assembly.CreateInstance(typeName) as AbstractCar;

            return instance;
        }
    }
}
