using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Graphs
{
      class Logger
    {
        static private bool flag = false;
        static public void writeLog(string log)
        {
            StreamWriter logger = new StreamWriter(@"C:\log.txt", flag);
            flag = true;
           
            logger.WriteLine(log);
          
            logger.Close();
            return;
        }

    }
}
