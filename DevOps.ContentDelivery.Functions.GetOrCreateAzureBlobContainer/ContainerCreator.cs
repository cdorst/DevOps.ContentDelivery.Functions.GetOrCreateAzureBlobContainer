using Microsoft.WindowsAzure.Storage.Blob;
using System.Threading.Tasks;

namespace DevOps.ContentDelivery.Functions.GetOrCreateAzureBlobContainer
{
    internal static class ContainerCreator
    {
        public static async Task EnsureCreated(CloudBlobContainer container)
            => await container.CreateIfNotExistsAsync(
                BlobContainerPublicAccessType.Blob,
                null,
                null);
    }
}
