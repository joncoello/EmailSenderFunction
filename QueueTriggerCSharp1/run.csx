using System;

public static void Run(string myQueueItem, TraceWriter log)
{
    var password = ConfigurationManager.ConnectionStrings["SmtpPassword"].ConnectionString;
    log.Info($"Password is: {password}");
    log.Info($"C# Queue trigger function processed x: {myQueueItem}");
}