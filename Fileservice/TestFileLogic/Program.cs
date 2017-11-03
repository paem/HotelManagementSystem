using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestFileLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogic.Main myFileMover= new FileLogic.Main();
            myFileMover.Start();

            var input = Console.ReadKey();
            if (input.Key.ToString() == "A")
                myFileMover.Stop();

            Console.ReadKey();
        }
    }
}
