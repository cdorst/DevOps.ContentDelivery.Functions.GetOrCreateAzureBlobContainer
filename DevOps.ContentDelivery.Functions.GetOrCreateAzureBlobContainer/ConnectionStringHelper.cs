using static System.Environment;

namespace DevOps.ContentDelivery.Functions.GetOrCreateAzureBlobContainer
{
    internal static class ConnectionStringHelper
    {
        private const string EnvironmentVariableName = "AZURE_BLOB_STORAGE_CONNECTION";

        public static string Connection(string connectionString)
            => string.IsNullOrWhiteSpace(connectionString)
                ? GetEnvironmentVariable(EnvironmentVariableName)
                : connectionString;
    }
}
