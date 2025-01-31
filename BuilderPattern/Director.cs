﻿namespace BuilderPattern
{
    /// <summary>
    /// 指挥者（采购经理）
    /// </summary>
    public class Director
    {
        public Computer Construct(Builder builder)
        {
           return builder.BuildComputer();
        }
    }
}