using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ta_te_ti_Game
{
    public interface IConsoleOutput
    {
        public void WriteLine(string message);
        public void Write(string message);
    }

    public class ConsoleOutput : IConsoleOutput
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
        public void Write(string message)
        {
            Console.Write(message);
        }
    }
}
