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

        static public void writeLog(string log)
        {
            StreamWriter logger = new StreamWriter(@"C:\log.txt");
            logger.WriteLine(log);
            logger.Close();
            return;
        }

    }
}
