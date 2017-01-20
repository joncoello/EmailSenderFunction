#r "SmtpEmailSender.DomainModel.dll"

using SmtpEmailSender.DomainModel.Providers;
using System;
using System.Configuration;

public static async Task Run(string myQueueItem, TraceWriter log)
{
    log.Info($"started");
    var password = ConfigurationManager.ConnectionStrings["SmtpPassword"].ConnectionString;
    log.Info($"got password");
    var smtpClient = new SmtpEmailProvider();
    log.Info($"created client");
    await smtpClient.Send(password);
    log.Info($"sent mail");
    log.Info($"C# Queue trigger function processed x: {myQueueItem}");
}