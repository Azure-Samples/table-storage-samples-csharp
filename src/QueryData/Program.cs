using Microsoft.Azure.Cosmos.Table;
using Shared;
using System;

namespace QueryData
{
    class Program
    {
        static void Main()
        {
            var table = TableService.GetTableReference("TestTable");
            TableService.FillWithSampleData(table);

            // Find books published before 1950 and return the first 5 sorted by author name.
            var query = new TableQuery<BookEntity>()
                .Where(TableQuery.GenerateFilterConditionForDate(nameof(BookEntity.PublicationDate), QueryComparisons.LessThan, new DateTime(1950, 1, 1)))
                .OrderBy(nameof(BookEntity.Authors))
                .Take(5);

            var queryResults = table.ExecuteQuery(query);
            foreach (var result in queryResults)
            {
                Console.WriteLine(result);
            }
        }
    }
}
