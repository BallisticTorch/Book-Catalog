using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Book_Catalog
{
    public class DataAccess
    {
        public List<Book> GetBookTitle(string book)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BryansLibrary")))
            {
                var output = connection.Query<Book>("dbo.spBook_GetByTitle @BookTitle", new { BookTitle = book }).ToList();
                return output;
            }
        }

        public List<Book> GetAuthorLastName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BryansLibrary")))
            {
                var output = connection.Query<Book>("dbo.spBook_GetByAuthor @AuthorLastName", new { AuthorLastName = name }).ToList();
                return output;
            }
        }

        public List<Book> GetGenre(string genre)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BryansLibrary")))
            {
                var output = connection.Query<Book>("dbo.spBook_GetByGenre @Genre", new { Genre = genre }).ToList();
                return output;
            }
        }

        public void SubmitBook(string isbnNumber, string bookTitle, string firstName, string middleName, string lastName, string bookSeries, string genre)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BryansLibrary")))
            {
                List<Book> book = new List<Book>();

                book.Add(new Book { ISBN = isbnNumber, BookTitle = bookTitle, AuthorFirstName = firstName, AuthorMiddleName = middleName, AuthorLastName = lastName, BookSeries = bookSeries, Genre = genre });

                connection.Execute("dbo.spBook_InsertNewBook @ISBN, @BookTitle, @AuthorFirstName, @AuthorMiddleName, @AuthorLastName, @BookSeries, @Genre", book);
            }
        }

        public string NumBooksUpdate()
        {
            DataAccess db = new DataAccess();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BryansLibrary")))
            {
                var output = connection.ExecuteScalar<int>("SELECT COUNT(*) FROM dbo.Book").ToString();
                return output;
            }
        }

        public string NumAuthorsUpdate()
        {
            DataAccess db = new DataAccess();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("BryansLibrary")))
            {
                var output = connection.ExecuteScalar<int>("SELECT COUNT (DISTINCT AuthorLastName) FROM dbo.Book").ToString();
                return output;
            }
        }
    }
}
