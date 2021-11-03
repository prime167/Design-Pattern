﻿using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Project webProject = new WebProject("Web项目");
            Manager projectManager = new ProjectManager(webProject);
            Manager productManager = new ProductManger(webProject);

            projectManager.ManageProject();
            productManager.ManageProject();

            Console.ReadLine();
        }
    }
}
