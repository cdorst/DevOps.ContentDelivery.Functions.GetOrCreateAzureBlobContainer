using Microsoft.WindowsAzure.Storage.Blob;
using System.Threading.Tasks;

namespace DevOps.ContentDelivery.Functions.GetOrCreateAzureBlobContainer
{
    internal static class ContainerCreator
    {
        public static async Task EnsureCreated(CloudBlobContainer container)
        {
            await container.CreateIfNotExistsAsync();
            await container.SetPermissionsAsync(
                new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
        }
    }
}
