using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text;

namespace Sdk4me.GraphQL.Tests
{
    [TestClass]
    public class BulkTest
    {
        private readonly Sdk4meClient client = Client.Get();

        [TestMethod]
        public void Export()
        {
            string csvPath = Path.Combine(Path.GetTempPath(), "4me_cis.csv");
            string zipPath = Path.Combine(Path.GetTempPath(), "4me_export.zip");

            string? result = client.Bulk.StartCsvExport(ExportLineSeparator.LineFeed, "cis").Result;
            Assert.IsNotNull(result);
            client.Bulk.AwaitDownloadAndSave(result, 5, csvPath).GetAwaiter().GetResult();
            FileInfo fileInfo = new(csvPath);
            Assert.IsTrue(fileInfo.Exists);
            Assert.IsTrue(fileInfo.Length > 0);

            result = client.Bulk.StartExcelExport("calendars", "holidays").Result;
            Assert.IsNotNull(result);
            client.Bulk.AwaitDownloadAndSave(result, 10, zipPath).GetAwaiter().GetResult();
            fileInfo = new(zipPath);
            Assert.IsTrue(fileInfo.Exists);
            Assert.IsTrue(fileInfo.Length > 0);

            result = client.Bulk.StartExcelExport("cis", "people", "services", "tasks").Result;
            Assert.IsNotNull(result);
            TimeoutException exception = Assert.ThrowsException<TimeoutException>(() =>
            {
                client.Bulk.AwaitDownloadAndSave(result, 10, zipPath, TimeSpan.FromSeconds(5)).GetAwaiter().GetResult();
            });
            Assert.IsNotNull(exception);
        }

        [TestMethod]
        public void Import()
        {
            string csvPath = Path.Combine(Path.GetTempPath(), "4me_cis_import.csv");

            File.WriteAllText(csvPath, $"\"ID\",Source,Source ID\n20,Sdk4me.GraphQL,\"{DateTime.Now:o}\"\n", new UTF8Encoding(false));
            string? result = client.Bulk.StartImport("cis", csvPath).Result;
            Assert.IsNotNull(result);
            BulkImportResponse importResult = client.Bulk.AwaitImport(result, 2, TimeSpan.FromMinutes(2)).Result;
            Assert.IsTrue(importResult.State == ImportExportStatus.Done);
            Assert.IsTrue(importResult.Results.Updated == 1);
        }
    }
}
