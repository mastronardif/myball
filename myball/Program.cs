using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using log4net;
using log4net.Config;
using System.Diagnostics;

namespace myball
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));
        //log4net.GlobalContext.Properties["pid"] = Process.GetCurrentProcess().Id;
        
        static void Init()
        {
            log4net.GlobalContext.Properties["LogPathModifier"] = "XXXX";
            log4net.GlobalContext.Properties["pid"] = Process.GetCurrentProcess().Id;
            //log4net.Config.BasicConfigurator.Configure();
            //log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            log4net.Util.SystemInfo.NullText = "wtf";
            //log.Logger. GlobalContext.Properties["pid"] = "ZZZ"; //Process.GetCurrentProcess().Id;
            //log4net.GlobalContext.Properties["pid"] =  Process.GetCurrentProcess().Id;
        }

        static void Main(string[] args)
        {
            Init();
            Testing();

            TimerCallback tmCallback = CheckEffectExpiry;
            Timer timer = new Timer(tmCallback, "test", 1000, 4*1000);
            Console.WriteLine("Press Enter key to exit the sample");
            Console.ReadLine();            
        }

        static void CheckEffectExpiry(object objectInfo)
        {
            //TODO put your code 
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(objectInfo);

            log.WarnFormat("Bewhare of the big bad log. {0}", DateTime.Now);
            log.Info("Info Message: " + "Hey dude whats up?");
            log.Debug("Debug Message: " + "review [my][you]");
            log.Error("Error Message: " + "retval = [123:345]");
            log.Fatal("Fatal Message: " + "I know out of memeory[low, very low]");
        }





        internal static void Testing()
        {
            log4net.Config.BasicConfigurator.Configure();
            log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));
            try
            {
                log.WarnFormat("Bewhare of the big bad {0}!", "Wolf");
                log.Info("Info Message: " + "Hey dude whats up?");
                string str = String.Empty;
                //string subStr = str.Substring(0, 4); //this line will create error as the string "str" is empty.  
            }
            catch (Exception ex)
            {
                log.Error("Error Message: " + ex.Message.ToString(), ex);
            }
        }
    }
}
