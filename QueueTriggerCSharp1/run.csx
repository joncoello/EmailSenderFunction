#r "SmtpEmailSender.DomainModel.dll"

using SmtpEmailSender.DomainModel.Providers;
using System;
using System.Configuration;

public static void Run(string myQueueItem, TraceWriter log)
{
    var password = ConfigurationManager.ConnectionStrings["SmtpPassword"].ConnectionString;
    var smtpClient = new SmtpEmailProvider();
    smtpClient.Send(password);
    log.Info($"C# Queue trigger function processed x: {myQueueItem}");
}