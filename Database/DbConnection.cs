using Dapper;
using System.Data;
using DictionaryGame;
using System.Data.SqlClient;
using DictionaryGame.Models;

namespace DictionaryGame.Database
{
    class DbConnection
    {
        private static string connectionString= @"
 Server=172.17.0.2;Database=test;User Id=sa;Password=;
";
        public IEnumerable<EnglishWord> GetWords()
        {
            try
            {
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                var english_words  = con.Query<EnglishWord>(@"
                select word Name,def Definition from english_words e
                INNER join definitions d on d.wordid=e.id"
                );
                return english_words;
            }
            }
            catch(Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.Message);
                return null;
            }
        } 
     

    }
}
