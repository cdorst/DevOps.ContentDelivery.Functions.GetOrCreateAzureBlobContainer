using Microsoft.WindowsAzure.Storage.Blob;
using System.Threading.Tasks;
using static DevOps.ContentDelivery.Functions.GetOrCreateAzureBlobContainer.ContainerCreator;
using static DevOps.ContentDelivery.Functions.GetOrCreateAzureBlobContainer.ContainerReferencer;

namespace DevOps.ContentDelivery.Functions.GetOrCreateAzureBlobContainer
{
    public static class ContainerReferenceGetter
    {
        public static async Task<CloudBlobContainer> Container(string name, string connectionString = null)
        {
            var container = Reference(name, connectionString);
            await EnsureCreated(container);
            return container;
        }
    }
}
