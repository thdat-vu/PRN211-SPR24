using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entities
{
	public class Book
	{
       
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Description   { get; set; }
        public DateTime PublicationDate { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public int BookCategoryId { get; set; }
        public string Author { get; set; }

        public override string ToString() => $"{BookId} | {BookName} | {Description}";


    }
}
