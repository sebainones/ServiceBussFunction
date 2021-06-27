using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace MessageQueuFunctionApp
{
    public static class MessageQueueFunction
    {
        [FunctionName("MessageQueueFunction")]
        public static void Run([QueueTrigger("sebasqueue", Connection = "AzureWebJobsStorage")] string myQueueItem, ILogger log)
        {
            log.LogInformation($"Local Queue trigger function processed: {myQueueItem}", null);
        }
    }
}
