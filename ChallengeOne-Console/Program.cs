using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOne_Console
{
    // single responsibility of Main method -- starts app 
    class Program
    {
        static void Main(string[] args)
        {
            ProgramUI run = new ProgramUI();
            run.Start();
        }
    }
}
