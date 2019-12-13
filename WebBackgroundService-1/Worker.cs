using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;

namespace WebBackgroundService_1
{
    public class Worker
    {
       

        public void StartProcessing(CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
   
                {
                    for (int index = 1; index <= 20; index++)
                    {
                        Thread.Sleep(1500);   // wait to 1.5 sec every time  
                    }


                }
            }
            catch (Exception ex)
            {
                ProcessCancellation();
            }
        }
        private void ProcessCancellation()
        {
            Thread.Sleep(10000);
        }
    }
}