using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using static DevOps.ContentDelivery.Functions.GetOrCreateAzureBlobContainer.ConnectionStringHelper;

namespace DevOps.ContentDelivery.Functions.GetOrCreateAzureBlobContainer
{
    internal static class ContainerReferencer
    {
        public static CloudBlobContainer Reference(string name, string connectionString)
            => CloudStorageAccount
                .Parse(Connection(connectionString))
                .CreateCloudBlobClient()
                .GetContainerReference(name);
    }
}
