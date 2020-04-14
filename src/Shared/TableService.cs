using Microsoft.Azure.Cosmos.Table;
using System;

namespace Shared
{
    public static class TableService
    {
        public static CloudTable GetTableReference(string tableName, bool createIfNotExists = false)
        {
            CloudStorageAccount account = CloudStorageAccount.Parse(TableService.StorageConnectionString);
            CloudTableClient client = account.CreateCloudTableClient();

            var table = client.GetTableReference(tableName);

            if (createIfNotExists)
            {
                table.CreateIfNotExists();
            }

            return table;
        }

        public static void FillWithSampleData(CloudTable table)
        {
            if (table == null)
            {
                throw new ArgumentNullException(nameof(table));
            }

            BookEntity[] books = new BookEntity[] { 
                new BookEntity()
                {
                    PartitionKey = "Agatha Christie",
                    RowKey = "979-8618555777",
                    Title = "The Secret Adversary",
                    Authors = "Agatha Christie",
                    ISBN = "979-8618555777",
                    PublicationDate = new DateTime(1922, 2, 26, 0, 0, 0, DateTimeKind.Utc),
                },
                new BookEntity()
                {
                    PartitionKey = "Ursula K. Le Guin",
                    RowKey = "978-0441478125",
                    Title = "The Left Hand of Darkness",
                    Authors = "Ursula K. Le Guin",
                    ISBN = "978-0441478125",
                    PublicationDate = new DateTime(1987, 3, 15, 0, 0, 0, DateTimeKind.Utc),
                },
                new BookEntity()
                {
                    PartitionKey = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides",
                    RowKey = "978-0201633610",
                    Title = "Design Patterns: Elements of Reusable Object-Oriented Software",
                    Authors = "Erich Gamma, Richard Helm, Ralph Johnson, John Vlissides",
                    ISBN = "978-0201633610",
                    PublicationDate = new DateTime(1994, 11, 10, 0, 0, 0, DateTimeKind.Utc),
                },
            };

            foreach (var book in books)
            {
                AddObject(table, book);
            }
        }

        public static void AddObject<T>(CloudTable table, T value) where T : ITableEntity
        {
            if (table == null)
            {
                throw new ArgumentNullException(nameof(table));
            }

            TableOperation operation = TableOperation.InsertOrReplace(value);
            table.Execute(operation);
        }

        public static string StorageConnectionString
        {
            get { return Environment.GetEnvironmentVariable(TableService.StorageConnectionStringVariableName); }
        }

        /// <summary>
        /// Environment variable name for the storage connection string.
        /// </summary>
        public const string StorageConnectionStringVariableName = "StorageConnectionString";
    }
}
