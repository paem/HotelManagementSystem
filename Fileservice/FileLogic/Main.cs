using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileLogic
{
    public class Main
    {
        Thread _MainThread;
        bool _StopFlag = false;

        //ToDo: Logging to file or eventlog
        public void Start()
        {
            try
            {
                if(_MainThread != null)
                {
                    if(_MainThread.ThreadState == ThreadState.Running)
                    { 
                        Console.WriteLine("Stopping current thread");
                        
                        //Lock to prevent other threads accessing thread 
                        lock (_MainThread)
                        {
                            _MainThread.Abort();
                        }
                    }
                 }
                _MainThread = new Thread(Run);
                _StopFlag = false;
                _MainThread.Start();
            }
            catch (Exception ex)
            {
                //ToDo: Logging to file or eventlog
                Console.WriteLine(ex.Message);
            }
        }

        //ToDo: Logging to file or eventlog
        private void Run()
        {
            try
            {
                Console.WriteLine("Filservice starting");
                FileChecker fileChecking = new FileChecker(@"C:\Users\Vidar\OneDrive\Dokument\HotelXml\");
                while (_StopFlag != true)
                {
                    fileChecking.MoveFilesFromFolder();
                    Thread.Sleep(500);  
                }
            }
            catch (Exception ex)
            {
                //ToDo: Logging to file or eventlog
                Console.WriteLine(ex.Message);
            }
        }

        public void Stop()
        {
            //ToDo: Logging to file or eventlog
            Console.WriteLine("Stopping filservice");
            _StopFlag = true;
        }
    }
}
