//using Lucene.Net.Codecs;
using ADOPSE_IMDB_IMITATION.Models;
using ADOPSE_IMDB_IMITATION.DataAccess;
using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lucene.Net;
using Lucene.Net.Store;
using Lucene.Net.Index;
using Lucene.Net.Documents;
using Lucene.Net.Util;
using Lucene.Net.Analysis;
using Lucene.Net.Analysis.Standard;
using Lucene.Net.Search;
using Lucene.Net.QueryParsers;

namespace ADOPSE_IMDB_IMITATION.DataAccess
{
    public static class index_test
    {
        public static void index_creator()
        {
            // To store an index on disk, use this instead:
            // Construct a machine-independent path for the index
            //var basePath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
            //var indexPath = Path.Combine(basePath, "index");
            //Directory directory = FSDirectory.Open(indexPath);

            string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\..\\Databases\\index_test\\";
            var dir = FSDirectory.Open(new DirectoryInfo(appPath));
            //var dir = FSDirectory.Open(new DirectoryInfo(@"C:\Users\thanasis\Documents\GitHub\ADOPSE_IMDB_IMITATION\ADOPSE_IMDB_IMITATION\Databases\index_test\"));
            var analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            var writer = new IndexWriter(dir, analyzer, IndexWriter.MaxFieldLength.UNLIMITED);

            List<Movie> allMovies = new List<Movie>();
            allMovies = MovieDataAccess.GetAllMovies();

            for (int i = 0; i < allMovies.Count(); i++)
            {
                Document doc = new Document();

                /*
                doc.Add(new Field(
                       dc.ColumnName,
                       dr[dc.ColumnName].ToString(),
                       Field.Store.YES,
                       Field.Index.TOKENIZED));
                */

                var date = Convert.ToDateTime(allMovies[i].ReleaseDate);
                int year = date.Year;

                doc.Add(new Field("Id", allMovies[i].Id.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
                doc.Add(new Field("Name", allMovies[i].Name, Field.Store.YES, Field.Index.ANALYZED));
                doc.Add(new Field("Year", year.ToString(), Field.Store.YES, Field.Index.NOT_ANALYZED));
                doc.Add(new Field("Director", allMovies[i].Director, Field.Store.YES, Field.Index.ANALYZED));

                //this is to get the genreIDs from GenreEntries that correspond to the movie id

                List<int> genreIds = GenresDataAccess.GetGenreIdsByMovieID(allMovies[i].Id);

                //this is to get the genre names from Genre table through previously fetched genreIds

                List<string> GenresList = new List<string>();
                foreach (int k in genreIds)
                {
                    String genreName = GenresDataAccess.GetGenreNameById(k);
                    GenresList.Add(genreName.Trim());
                }

                string Genres = string.Join(" ", GenresList);
                doc.Add(new Field("Genres", Genres, Field.Store.YES, Field.Index.ANALYZED));

                writer.AddDocument(doc);
            }

            writer.Optimize();
            writer.Commit();
            writer.Dispose();
        }

        public static void index_searcher_by_name(string title_to_search)
        {
            string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\..\\Databases\\index_test\\";
            var dir = FSDirectory.Open(new DirectoryInfo(appPath));

            //var dir = FSDirectory.Open(new DirectoryInfo(@"C:\Users\thanasis\Documents\GitHub\ADOPSE_IMDB_IMITATION\ADOPSE_IMDB_IMITATION\Databases\index_test\"));
            var analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);

            IndexSearcher searcher = new IndexSearcher(dir);
            QueryParser parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, "Name", analyzer);
            Query query = parser.Parse(title_to_search);
            TopDocs topDocs = searcher.Search(query, 10);

            int results = topDocs.ScoreDocs.Length;
            Console.WriteLine("Found {0} results", results);

            for (int i = 0; i < results; i++)
            {
                ScoreDoc scoreDoc = topDocs.ScoreDocs[i];
                float score = scoreDoc.Score;
                int docId = scoreDoc.Doc;
                Document doc = searcher.Doc(docId);

                //Console.WriteLine("{0}. score {1}", i + 1, score);
                //Console.WriteLine("ID: {0}", doc.Get("id"));
                //Console.WriteLine("Text found: {0}\r\nwith genres {1}", doc.Get("Name"), doc.Get("Genres"));
                Console.WriteLine("Text found: >" + doc.Get("Name") + "<" + ">" + doc.Get("Genres")  +"<");
            }
        }

        public static void index_searcher_by_year()
        {
            string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\..\\Databases\\index_test\\";
            var dir = FSDirectory.Open(new DirectoryInfo(appPath));
            //var dir = FSDirectory.Open(new DirectoryInfo(@"C:\Users\thanasis\Documents\GitHub\ADOPSE_IMDB_IMITATION\ADOPSE_IMDB_IMITATION\Databases\index_test\"));
            var analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);

            IndexSearcher searcher = new IndexSearcher(dir);
            QueryParser parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, "Year", analyzer);
            Query query = parser.Parse("2021");
            TopDocs topDocs = searcher.Search(query, 10);

            int results = topDocs.ScoreDocs.Length;
            Console.WriteLine("Found {0} results", results);

            for (int i = 0; i < results; i++)
            {
                ScoreDoc scoreDoc = topDocs.ScoreDocs[i];
                float score = scoreDoc.Score;
                int docId = scoreDoc.Doc;
                Document doc = searcher.Doc(docId);

                //Console.WriteLine("{0}. score {1}", i + 1, score);
                //Console.WriteLine("ID: {0}", doc.Get("id"));
                Console.WriteLine("Text found: {0}\r\n", doc.Get("Name"));
            }
        }

        public static void index_searcher_by_genre()
        {
            string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\..\\..\\Databases\\index_test\\";
            var dir = FSDirectory.Open(new DirectoryInfo(appPath));
            //var dir = FSDirectory.Open(new DirectoryInfo(@"C:\Users\thanasis\Documents\GitHub\ADOPSE_IMDB_IMITATION\ADOPSE_IMDB_IMITATION\Databases\index_test\"));
            var analyzer = new StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);

            IndexSearcher searcher = new IndexSearcher(dir);
            QueryParser parser = new QueryParser(Lucene.Net.Util.Version.LUCENE_30, "Genres", analyzer);
            Query query = parser.Parse("Drama");
            TopDocs topDocs = searcher.Search(query, 10);

            int results = topDocs.ScoreDocs.Length;
            Console.WriteLine("Found {0} results", results);

            for (int i = 0; i < results; i++)
            {
                ScoreDoc scoreDoc = topDocs.ScoreDocs[i];
                float score = scoreDoc.Score;
                int docId = scoreDoc.Doc;
                Document doc = searcher.Doc(docId);

                //Console.WriteLine("{0}. score {1}", i + 1, score);
                //Console.WriteLine("ID: {0}", doc.Get("id"));
                Console.WriteLine("Text found: {0}\r\n", doc.Get("Name"));
            }
        }
    }
}