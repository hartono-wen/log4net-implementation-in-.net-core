using System;
using System.IO;
using System.Reflection;
using log4net;
using log4net.Config;
using log4net.Repository;

namespace Log4NetImplementationInDotNetCore
{
    class Program
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            ILoggerRepository logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

            log.Info("If you see this, it means that log4net is working.");
            log.Debug("If you see this, it means that log4net is working.");
            log.Warn("If you see this, it means that log4net is working.");
            log.Error("If you see this, it means that log4net is working.");
            log.Fatal("If you see this, it means that log4net is working.");
        }
    }
}
