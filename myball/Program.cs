using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myball
{
    class Program
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

        static void Init()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
        }

        static void Main(string[] args)
        {
            Init();
            Testing();
            Console.ReadLine();
        }

        internal static void Testing()
        {
            //log4net.Config.BasicConfigurator.Configure();
            //log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            try
            {
                log.WarnFormat("Bewhare of the big bad {0}!", "Wolf");
                log.Info("Info Message: " + "Hey dude whats up?");
                string str = String.Empty;
                string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty.  
            }
            catch (Exception ex)
            {
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
        }
    }
}
