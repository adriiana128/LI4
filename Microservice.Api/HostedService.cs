
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Microservice
{
    /// <summary>
    /// This class is run in startup when the service is loaded and used to call application processes 
    /// which run in the background regardless to any Rest Api calls.
    /// </summary>
    public class HostedService : IHostedService
    {
        //protected Application.QueueReceiver _queueReceiver;

        public Task StartAsync(CancellationToken cancellationToken)
        {
            //_queueReceiver = new Application.QueueReceiver();
            //_queueReceiver.Start();
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            //_queueReceiver.Stop();
            return Task.CompletedTask;
        }
    }
}
