using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ta_te_ti_Game
{
    public interface IConsoleInput {
        public String ReadLine();
    }

    public class ConsoleInput : IConsoleInput
    {
        public string ReadLine() => Console.ReadLine();
    }
}
