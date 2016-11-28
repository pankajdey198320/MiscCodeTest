using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Console
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

   
}

namespace Log.Interface
{
    public interface Ilogger
    {
        void Log(string logText);
    }


    public interface ILoggerContext
    {

    }
    public interface ILoggerFactory
    {
        Ilogger GetLogger(ILoggerContext context);
    }
}