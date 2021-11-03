using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
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