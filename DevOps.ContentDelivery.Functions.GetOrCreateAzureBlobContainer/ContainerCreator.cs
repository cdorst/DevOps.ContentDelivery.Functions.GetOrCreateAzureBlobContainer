using Microsoft.WindowsAzure.Storage.Blob;
using System.Threading.Tasks;

namespace DevOps.ContentDelivery.Functions.GetOrCreateAzureBlobContainer
{
    internal static class ContainerCreator
    {
        public static async Task EnsureCreated(CloudBlobContainer container)
        {
            await container.CreateIfNotExistsAsync();
            await SetPublicAccessPermission(container);
        }

        private static async Task SetPublicAccessPermission(CloudBlobContainer container)
        {
            var permissions = await container.GetPermissionsAsync();
            permissions.PublicAccess = BlobContainerPublicAccessType.Blob;
            await container.SetPermissionsAsync(permissions);
        }
    }
}
