using Microsoft.Azure.Cosmos.Table;
using System;
using System.Globalization;

namespace Shared
{
    public class BookEntity : TableEntity
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        public DateTime PublicationDate { get; set; }

        public override string ToString()
        {
            return string.Format(
                CultureInfo.CurrentCulture,
                "\"{0}\" by {1} ({2}, {3})",
                this.Title,
                this.Authors,
                this.ISBN,
                this.PublicationDate);
        }
    }
}
