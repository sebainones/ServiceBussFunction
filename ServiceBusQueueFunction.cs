using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace MessageQueuFunctionApp
{
    public static class ServiceBusQueueFunction
    {
        [FunctionName("ServiceBusQueueTrigger")]
        [return: Queue("sebasqueue", Connection = "AzureWebJobsStorage")]
        public static string Run([ServiceBusTrigger("ghaseelqueue", Connection = "ServiceBusConnection")] string myQueueItem, ILogger log)
        {
            log.LogInformation($"ServiceBus queue trigger function  message: {myQueueItem}", null);
            return myQueueItem;
        }
    }
}
