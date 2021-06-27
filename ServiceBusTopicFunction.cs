using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace MessageQueueFunctionApp
{
    public static class ServiceBusTopicFunction
    {
        [FunctionName("ServiceBusTopicFunction")]
        public static void Run([ServiceBusTrigger("ghaseeltopic", "ghaseeltopicsubscription", Connection = "ServiceBusConnection")]string mySbMsg, ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function message: {mySbMsg}");
        }
    }
}
