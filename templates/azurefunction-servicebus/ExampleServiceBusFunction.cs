using System;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Azure.ServiceBus;
using Microsoft.Azure.WebJobs;
// Add package: "Microsoft.Azure.WebJobs.Extensions.ServiceBus" 
using Microsoft.Extensions.Logging;

namespace DependencyInjectionExample
{
    public class ExampleServiceBusFunction
    {
        //Set a connectionstring in your config
        const string ConnectionStringName = "ServiceBusConnectionStringName";

        public ExampleServiceBusFunction(/* add dependencies here */)
        {

        }

        [FunctionName(nameof(ReceiveMessageFromQueue))]
        public async Task ReceiveMessageFromQueue(
          [ServiceBusTrigger("QueueName", Connection = ConnectionStringName)]Message sbMessage,
          ILogger log)
        {
            //Add fun
        }

        [FunctionName(nameof(ReceiveMessageFromSubscription))]
        public async Task ReceiveMessageFromSubscription(
          [ServiceBusTrigger("TopicName", "SubscriptionName", Connection = ConnectionStringName)]Message sbMessage,
          ILogger log)
        {
            //Add fun
        }

        [FunctionName(nameof(SendMessageToTopicOrQueue))]
        public async Task SendMessageToTopicOrQueue(
       [ServiceBusTrigger("TopicName", "SubscriptionName", Connection = ConnectionStringName)]Message sbMessage,
       [ServiceBus("OutgoingQueueOrTopic", Connection = "ServiceBusConnectionStringName")] IAsyncCollector<string> outgoingQueueOrTopic,
       ILogger log)
        {
            await outgoingQueueOrTopic.AddAsync("somedata");
            
            await outgoingQueueOrTopic.FlushAsync();
        }



    }
}
