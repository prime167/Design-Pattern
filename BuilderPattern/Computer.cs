using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    /// <summary>
    /// 产品类
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// 品牌
        /// </summary>
        public string Band { get; set; }

        /// <summary>
        /// 电脑组件列表
        /// </summary>
        private readonly List<string> _assemblyParts = new List<string>();

        /// <summary>
        /// 组装部件
        /// </summary>
        /// <param name="partName">部件名称</param>
        public void AssemblePart(string partName)
        {
            this._assemblyParts.Add(partName);
        }

        public void ShowSteps()
        {
            Console.WriteLine("开始组装『{0}』电脑:", Band);
            foreach (var part in _assemblyParts)
            {
                Console.WriteLine($"组装『{part}』;");
            }

            Console.WriteLine("组装『{0}』电脑完毕！", Band);
        }
    }
}