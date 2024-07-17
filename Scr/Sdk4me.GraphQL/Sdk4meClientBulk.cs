using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Sdk4me.GraphQL
{
    /// <summary>
    /// Provides methods for bulk operations with the 4me API.
    /// </summary>
    public class Sdk4meClientBulk
    {
        private readonly Sdk4meClient client;

        internal Sdk4meClientBulk(Sdk4meClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// Starts a 4me CSV export.
        /// <para>Note: More details and the supported types can be found on the <see href="https://developer.4me.com/v1/export/#parameters">4me developer pages</see>.</para>
        /// </summary>
        /// <param name="lineSeparator">The line separator for the CSV export file.</param>
        /// <param name="types">The type or types of files to export. Must contain at least one value.</param>
        /// <exception cref="ArgumentException">Thrown when no types are specified.</exception>
        /// <returns>A task representing the asynchronous operation, with a string result containing the export token if the operation succeeds, or null when there is no exportable data.</returns>
        public async Task<string?> StartCsvExport(ExportLineSeparator lineSeparator, params string[] types)
        {
            return await client.StartExport(null, "csv", lineSeparator, types);
        }

        /// <summary>
        /// Starts a 4me CSV export.
        /// <para>Note: More details and the supported types can be found on the <see href="https://developer.4me.com/v1/export/#parameters">4me developer pages</see>.</para>
        /// </summary>
        /// <param name="from">The date after which a record needs to have been created or updated in order to be included in the export.</param>
        /// <param name="lineSeparator">The line separator for the CSV export file.</param>
        /// <param name="types">The type or types of files to export. Must contain at least one value.</param>
        /// <exception cref="ArgumentException">Thrown when no types are specified.</exception>
        /// <returns>A task representing the asynchronous operation, with a string result containing the export token if the operation succeeds, or null when there is no exportable data.</returns>
        public async Task<string?> StartCsvExport(DateTime from, ExportLineSeparator lineSeparator, params string[] types)
        {
            return await client.StartExport(from, "csv", lineSeparator, types);
        }

        /// <summary>
        /// Starts a 4me XLSX export.
        /// <para>Note: More details and the supported types can be found on the <see href="https://developer.4me.com/v1/export/#parameters">4me developer pages</see>.</para>
        /// </summary>
        /// <param name="types">The type or types of files to export. Must contain at least one value.</param>
        /// <exception cref="ArgumentException">Thrown when no types are specified.</exception>
        /// <returns>A task representing the asynchronous operation, with a string result containing the export token if the operation succeeds, or null when there is no exportable data.</returns>
        public async Task<string?> StartExcelExport(params string[] types)
        {
            return await client.StartExport(null, "xlsx", null, types);
        }

        /// <summary>
        /// Starts a 4me XLSX export.
        /// <para>Note: More details and the supported types can be found on the <see href="https://developer.4me.com/v1/export/#parameters">4me developer pages</see>.</para>
        /// </summary>
        /// <param name="from">The date after which a record needs to have been created or updated in order to be included in the export.</param>
        /// <param name="types">The type or types of files to export. Must contain at least one value.</param>
        /// <exception cref="ArgumentException">Thrown when no types are specified.</exception>
        /// <returns>A task representing the asynchronous operation, with a string result containing the export token if the operation succeeds, or null when there is no exportable data.</returns>
        public async Task<string?> StartExcelExport(DateTime from, params string[] types)
        {
            return await client.StartExport(from, "xlsx", null, types);
        }

        /// <summary>
        /// Gets the export status.
        /// </summary>
        /// <param name="token">The export token.</param>
        /// <returns>A task representing the asynchronous operation, with an <see cref="BulkExportResponse"/> containing detailed information about the export process.</returns>
        public async Task<BulkExportResponse> GetExportStatus(string token)
        {
            return await client.GetImportExportStatus<BulkExportResponse>(token, CancellationToken.None);
        }

        /// <summary>
        /// Downloads a file from the specified URL in the <see cref="BulkExportResponse"/>.
        /// </summary>
        /// <param name="exportResponse">The export response containing the URL of the file to download.</param>
        /// <returns>A task representing the asynchronous operation, with a stream representing the file content.</returns>
        /// <exception cref="ArgumentException">Thrown when the export state is not done.</exception>
        /// <exception cref="ArgumentNullException">Thrown when the URL in the exportStatusResponse is null or empty.</exception>
        public async Task<Stream> Download(BulkExportResponse exportResponse)
        {
            if (exportResponse.State != ImportExportStatus.Done)
                throw new ArgumentException("The export process is not yet completed.");

            if (exportResponse.State == ImportExportStatus.Failed || exportResponse.State == ImportExportStatus.Error)
                throw new Sdk4meException("The export process failed.");

            if (string.IsNullOrEmpty(exportResponse.Url))
                throw new ArgumentNullException(nameof(exportResponse), "The URL cannot be null or empty.");

            HttpClient client = new();
            Stream responseStream = await client.GetStreamAsync(exportResponse.Url);
            return new HttpClientStreamWrapper(client, responseStream);
        }

        /// <summary>
        /// Waits for the export to complete and then downloads the file.
        /// <para>Be mindful of the API rate limit when setting the polling interval.</para>
        /// </summary>
        /// <param name="token">The export token.</param>
        /// <param name="pollingIntervalInSeconds">
        /// The interval in seconds to wait between status checks. Must be between 2 seconds and 900 seconds (15 minutes).
        /// Select the interval based on the expected number of objects to be exported, as frequent polling can potentially exceed the API rate limit.
        /// </param>
        /// <returns>A task representing the asynchronous operation, with a stream representing the file content.</returns>
        /// <exception cref="Sdk4meException">Thrown when the export fails.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the polling interval is outside the allowed range.</exception>
        public async Task<Stream> AwaitDownload(string token, int pollingIntervalInSeconds)
        {
            return await AwaitDownload(token, pollingIntervalInSeconds, CancellationToken.None);
        }

        /// <summary>
        /// Waits for the export to complete and then downloads the file.
        /// <para>Be mindful of the API rate limit when setting the polling interval.</para>
        /// </summary>
        /// <param name="token">The export token.</param>
        /// <param name="pollingIntervalInSeconds">
        /// The interval in seconds to wait between status checks. Must be between 2 seconds and 900 seconds (15 minutes).
        /// Select the interval based on the expected number of objects to be exported, as frequent polling can potentially exceed the API rate limit.
        /// </param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>A task representing the asynchronous operation, with a stream representing the file content.</returns>
        /// <exception cref="Sdk4meException">Thrown when the export fails.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the polling interval is outside the allowed range.</exception>
        public async Task<Stream> AwaitDownload(string token, int pollingIntervalInSeconds, CancellationToken cancellationToken)
        {
            if (pollingIntervalInSeconds < 2 || pollingIntervalInSeconds > 900)
                throw new ArgumentOutOfRangeException(nameof(pollingIntervalInSeconds), "Polling interval must be between 2 seconds and 900 seconds.");

            BulkExportResponse response = await client.GetImportExportStatus<BulkExportResponse>(token, cancellationToken);
            while (response.State != ImportExportStatus.Done)
            {
                cancellationToken.ThrowIfCancellationRequested();

                if (response.State == ImportExportStatus.Failed || response.State == ImportExportStatus.Error)
                    throw new Sdk4meException("The export process failed.");

                await System.Threading.Tasks.Task.Delay(pollingIntervalInSeconds * 1000, cancellationToken);
                response = await client.GetImportExportStatus<BulkExportResponse>(token, cancellationToken);
            }
            return await Download(response);
        }

        /// <summary>
        /// Waits for the export to complete and then downloads the file.
        /// <para>Be mindful of the API rate limit when setting the polling interval.</para>
        /// </summary>
        /// <param name="token">The export token.</param>
        /// <param name="pollingIntervalInSeconds">
        /// The interval in seconds to wait between status checks. Must be between 2 seconds and 900 seconds (15 minutes).
        /// Select the interval based on the expected number of objects to be exported, as frequent polling can potentially exceed the API rate limit.
        /// </param>
        /// <param name="timeout">
        /// The maximum time to wait for the export to complete. If the export process does not complete within this time, a <see cref="TimeoutException"/> will be thrown.
        /// <para>A value of TimeSpan.Zero means the operation will wait indefinitely until the export is completed or fails.</para>
        /// </param>
        /// <returns>A task representing the asynchronous operation, with a stream representing the file content.</returns>
        /// <exception cref="Sdk4meException">Thrown when the export fails.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the polling interval is outside the allowed range.</exception>
        /// <exception cref="TimeoutException">Thrown when the operation times out.</exception>
        public async Task<Stream> AwaitDownload(string token, int pollingIntervalInSeconds, TimeSpan timeout)
        {
            if (pollingIntervalInSeconds < 2 || pollingIntervalInSeconds > 900)
                throw new ArgumentOutOfRangeException(nameof(pollingIntervalInSeconds), "Polling interval must be between 2 seconds and 900 seconds.");

            DateTime startTime = DateTime.UtcNow;
            DateTime lastRequestTime = DateTime.UtcNow;

            BulkExportResponse response = await client.GetImportExportStatus<BulkExportResponse>(token, CancellationToken.None);

            if (response.State == ImportExportStatus.Failed || response.State == ImportExportStatus.Error)
                throw new Sdk4meException("The export process failed.");

            while (response.State != ImportExportStatus.Done)
            {
                TimeSpan elapsed = DateTime.UtcNow - startTime;
                if (timeout > TimeSpan.Zero && elapsed > timeout)
                    throw new TimeoutException($"The await download operation for token '{token}' has timed out after {elapsed.TotalSeconds:N2} seconds, exceeding the timeout limit of {timeout.TotalSeconds} seconds.");

                if ((DateTime.UtcNow - lastRequestTime).TotalSeconds >= pollingIntervalInSeconds)
                {
                    response = await client.GetImportExportStatus<BulkExportResponse>(token, CancellationToken.None);
                    lastRequestTime = DateTime.UtcNow;

                    if (response.State == ImportExportStatus.Failed || response.State == ImportExportStatus.Error)
                        throw new Sdk4meException("The export process failed.");

                }
                await System.Threading.Tasks.Task.Delay(1000);
            }
            return await Download(response);
        }

        /// <summary>
        /// Waits for the export to complete, downloads the file, and saves it to the specified path.
        /// <para>Be mindful of the API rate limit when setting the polling interval.</para>
        /// </summary>
        /// <param name="token">The export token.</param>
        /// <param name="pollingIntervalInSeconds">
        /// The interval in seconds to wait between status checks. Must be between 2 seconds and 900 seconds (15 minutes).
        /// Select the interval based on the expected number of objects to be exported, as frequent polling can potentially exceed the API rate limit.
        /// </param>
        /// <param name="path">The file path where the downloaded content will be saved.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException">Thrown when the export fails.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the polling interval is outside the allowed range.</exception>
        public async System.Threading.Tasks.Task AwaitDownloadAndSave(string token, int pollingIntervalInSeconds, string path)
        {
            await AwaitDownloadAndSave(token, pollingIntervalInSeconds, path, CancellationToken.None);
        }

        /// <summary>
        /// Waits for the export to complete, downloads the file, and saves it to the specified path.
        /// <para>Be mindful of the API rate limit when setting the polling interval.</para>
        /// </summary>
        /// <param name="token">The export token.</param>
        /// <param name="pollingIntervalInSeconds">
        /// The interval in seconds to wait between status checks. Must be between 2 seconds and 900 seconds (15 minutes).
        /// Select the interval based on the expected number of objects to be exported, as frequent polling can potentially exceed the API rate limit.
        /// </param>
        /// <param name="path">The file path where the downloaded content will be saved.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException">Thrown when the export fails.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the polling interval is outside the allowed range.</exception>
        public async System.Threading.Tasks.Task AwaitDownloadAndSave(string token, int pollingIntervalInSeconds, string path, CancellationToken cancellationToken)
        {
            using (Stream downloadStream = await AwaitDownload(token, pollingIntervalInSeconds, cancellationToken))
            {
                using (FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
#if NET6_0_OR_GREATER
                        await downloadStream.CopyToAsync(fileStream, cancellationToken);
#else
                        await downloadStream.CopyToAsync(fileStream);
#endif
                }
            }
        }

        /// <summary>
        /// Waits for the export to complete, downloads the file, and saves it to the specified path.
        /// <para>Be mindful of the API rate limit when setting the polling interval.</para>
        /// </summary>
        /// <param name="token">The export token.</param>
        /// <param name="pollingIntervalInSeconds">
        /// The interval in seconds to wait between status checks. Must be between 2 seconds and 900 seconds (15 minutes).
        /// Select the interval based on the expected number of objects to be exported, as frequent polling can potentially exceed the API rate limit.
        /// </param>
        /// <param name="path">The file path where the downloaded content will be saved.</param>
        /// <param name="timeout">
        /// The maximum time to wait for the export to complete. If the export process does not complete within this time, a <see cref="TimeoutException"/> will be thrown.
        /// <para>A value of TimeSpan.Zero means the operation will wait indefinitely until the export is completed or fails.</para>
        /// </param>
        /// <returns>A task representing the asynchronous operation.</returns>
        /// <exception cref="Sdk4meException">Thrown when the export fails.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the polling interval is outside the allowed range.</exception>
        /// <exception cref="TimeoutException">Thrown when the operation times out.</exception>
        public async System.Threading.Tasks.Task AwaitDownloadAndSave(string token, int pollingIntervalInSeconds, string path, TimeSpan timeout)
        {
            using (Stream downloadStream = await AwaitDownload(token, pollingIntervalInSeconds, timeout))
            {
                using (FileStream fileStream = new(path, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    await downloadStream.CopyToAsync(fileStream);
                }
            }
        }

        /// <summary>
        /// Starts an import process by uploading the specified file from the provided path.
        /// </summary>
        /// <param name="type">The type of the import.</param>
        /// <param name="path">The file path of the file to be imported.</param>
        /// <returns>A task representing the asynchronous operation, with a string result containing the import token if the operation succeeds, or null if it fails.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="type"/> or <paramref name="path"/> is null or empty.</exception>
        /// <exception cref="FileNotFoundException">Thrown when the file at the specified path does not exist.</exception>
        public async Task<string?> StartImport(string type, string path)
        {
            if (string.IsNullOrEmpty(type))
                throw new ArgumentException($"'{nameof(type)}' cannot be null or empty.", nameof(type));

            if (string.IsNullOrEmpty(path))
                throw new ArgumentException($"'{nameof(path)}' cannot be null or empty.", nameof(path));

            if (!File.Exists(path))
                throw new FileNotFoundException("The specified file was not found.", path);

            using (FileStream stream = new(path, FileMode.Open, FileAccess.Read))
                return await StartImport(type, Path.GetFileName(path), stream);
        }

        /// <summary>
        /// Starts an import process by uploading the specified data.
        /// </summary>
        /// <param name="type">The type of the import.</param>
        /// <param name="filename">The name of the file being imported.</param>
        /// <param name="streamReader">The stream reader containing the file data to be imported.</param>
        /// <returns>A task representing the asynchronous operation, with a string result containing the import token if the operation succeeds, or null if it fails.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="type"/>, <paramref name="filename"/>, or <paramref name="streamReader"/> is null or empty.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="streamReader"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the file extension is not .csv or .tsv.</exception>
        public async Task<string?> StartImport(string type, string filename, StreamReader streamReader)
        {
            return await StartImport(type, filename, streamReader.BaseStream);
        }

        /// <summary>
        /// Starts an import process by uploading the specified data.
        /// </summary>
        /// <param name="type">The type of the import.</param>
        /// <param name="filename">The name of the file being imported.</param>
        /// <param name="stream">The stream containing the file data to be imported.</param>
        /// <returns>A task representing the asynchronous operation, with a string result containing the import token if the operation succeeds, or null if it fails.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="type"/>, <paramref name="filename"/>, or <paramref name="stream"/> is null or empty.</exception>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="stream"/> is null.</exception>
        /// <exception cref="ArgumentException">Thrown when the file extension is not .csv or .tsv.</exception>
        public async Task<string?> StartImport(string type, string filename, Stream stream)
        {
            if (string.IsNullOrEmpty(type))
                throw new ArgumentException($"'{nameof(type)}' cannot be null or empty.", nameof(type));
            
            if (string.IsNullOrEmpty(filename))
                throw new ArgumentException($"'{nameof(filename)}' cannot be null or empty.", nameof(filename));
            
            if (stream is null)
                throw new ArgumentNullException(nameof(stream));

            if (!Path.GetExtension(filename).Equals(".csv", StringComparison.OrdinalIgnoreCase) && !Path.GetExtension(filename).Equals(".tsv", StringComparison.OrdinalIgnoreCase))
                throw new ArgumentException("The file must have a .csv or .tsv extension.", nameof(filename));

            return await client.StartImport(type, Path.GetFileName(filename), stream);
        }

        /// <summary>
        /// Gets the import status.
        /// </summary>
        /// <param name="token">The import token.</param>
        /// <returns>A task representing the asynchronous operation, with an <see cref="BulkImportResponse"/> containing detailed information about the import process.</returns>
        public async Task<BulkImportResponse> GetImportStatus(string token)
        {
            return await client.GetImportExportStatus<BulkImportResponse>(token, CancellationToken.None);
        }

        /// <summary>
        /// Waits for the import process to complete by periodically checking the import status.
        /// <para>Be mindful of the API rate limit when setting the polling interval.</para>
        /// </summary>
        /// <param name="token">The import token.</param>
        /// <param name="pollingIntervalInSeconds">
        /// The interval in seconds to wait between status checks. Must be between 2 seconds and 900 seconds (15 minutes).
        /// Select the interval based on the expected number of objects to be imported, as frequent polling can potentially exceed the API rate limit.
        /// </param>
        /// <returns>A task representing the asynchronous operation, with the final <see cref="BulkImportResponse"/> indicating the outcome of the import process.</returns>
        /// <exception cref="Sdk4meException">Thrown when the import process fails.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the polling interval is outside the allowed range.</exception>
        public async Task<BulkImportResponse> AwaitImport(string token, int pollingIntervalInSeconds)
        {
            return await AwaitImport(token, pollingIntervalInSeconds, CancellationToken.None);
        }

        /// <summary>
        /// Waits for the import process to complete by periodically checking the import status.
        /// <para>Be mindful of the API rate limit when setting the polling interval.</para>
        /// </summary>
        /// <param name="token">The import token.</param>
        /// <param name="pollingIntervalInSeconds">
        /// The interval in seconds to wait between status checks. Must be between 2 seconds and 900 seconds (15 minutes).
        /// Select the interval based on the expected number of objects to be imported, as frequent polling can potentially exceed the API rate limit.
        /// </param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>A task representing the asynchronous operation, with the final <see cref="BulkImportResponse"/> indicating the outcome of the import process.</returns>
        /// <exception cref="Sdk4meException">Thrown when the import process fails.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the polling interval is outside the allowed range.</exception>
        public async Task<BulkImportResponse> AwaitImport(string token, int pollingIntervalInSeconds, CancellationToken cancellationToken)
        {
            if (pollingIntervalInSeconds < 2 || pollingIntervalInSeconds > 900)
                throw new ArgumentOutOfRangeException(nameof(pollingIntervalInSeconds), "Polling interval must be between 2 seconds and 900 seconds.");

            BulkImportResponse response = await client.GetImportExportStatus<BulkImportResponse>(token, cancellationToken);
            while (response.State != ImportExportStatus.Done && response.State != ImportExportStatus.Failed && response.State != ImportExportStatus.Error)
            {
                cancellationToken.ThrowIfCancellationRequested();

                await System.Threading.Tasks.Task.Delay(pollingIntervalInSeconds * 1000, cancellationToken);
                response = await client.GetImportExportStatus<BulkImportResponse>(token, cancellationToken);
            }
            return response;
        }

        /// <summary>
        /// Waits for the import process to complete by periodically checking the import status.
        /// <para>Be mindful of the API rate limit when setting the polling interval.</para>
        /// </summary>
        /// <param name="token">The import token.</param>
        /// <param name="pollingIntervalInSeconds">
        /// The interval in seconds to wait between status checks. Must be between 2 seconds and 900 seconds (15 minutes).
        /// Select the interval based on the expected number of objects to be imported, as frequent polling can potentially exceed the API rate limit.
        /// </param>
        /// <param name="timeout">
        /// The maximum time to wait for the export to complete. If the export process does not complete within this time, a <see cref="TimeoutException"/> will be thrown.
        /// <para>A value of TimeSpan.Zero means the operation will wait indefinitely until the import is completed or fails.</para>
        /// </param>
        /// <returns>A task representing the asynchronous operation, with the final <see cref="BulkImportResponse"/> indicating the outcome of the import process.</returns>
        /// <exception cref="Sdk4meException">Thrown when the import process fails.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when the polling interval is outside the allowed range.</exception>
        /// <exception cref="TimeoutException">Thrown when the operation times out.</exception>
        public async Task<BulkImportResponse> AwaitImport(string token, int pollingIntervalInSeconds, TimeSpan timeout)
        {
            if (pollingIntervalInSeconds < 2 || pollingIntervalInSeconds > 900)
                throw new ArgumentOutOfRangeException(nameof(pollingIntervalInSeconds), "Polling interval must be between 2 seconds and 900 seconds.");

            DateTime startTime = DateTime.UtcNow;
            DateTime lastRequestTime = DateTime.UtcNow;

            BulkImportResponse response = await client.GetImportExportStatus<BulkImportResponse>(token, CancellationToken.None);
            while (response.State != ImportExportStatus.Done && response.State != ImportExportStatus.Failed && response.State != ImportExportStatus.Error)
            {
                TimeSpan elapsed = DateTime.UtcNow - startTime;
                if (timeout > TimeSpan.Zero && elapsed > timeout)
                    throw new TimeoutException($"The await import operation for token '{token}' has timed out after {elapsed.TotalSeconds:N2} seconds, exceeding the timeout limit of {timeout.TotalSeconds} seconds.");

                if ((DateTime.UtcNow - lastRequestTime).TotalSeconds >= pollingIntervalInSeconds)
                {
                    response = await client.GetImportExportStatus<BulkImportResponse>(token, CancellationToken.None);
                    lastRequestTime = DateTime.UtcNow;
                }

                await System.Threading.Tasks.Task.Delay(1000);
            }
            return response;
        }
    }
}
