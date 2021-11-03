using System;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            HpBuilder hpBuilder = new HpBuilder();
            DellBuilder dellBuilder =new DellBuilder();

            //组装一批惠普电脑
            Computer hp =director.Construct(hpBuilder);
            hp.ShowSteps();

            Console.WriteLine();

            //组装一批戴尔电脑
            Computer dell = director.Construct(dellBuilder);
            dell.ShowSteps();
        }
    }
}
