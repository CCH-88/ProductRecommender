

using System.Globalization;

namespace ProductRecommender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string rawCSV = System.IO.File.ReadAllText(@"C:\Users\B053643\source\repos\ProductRecommender\Data\grades.txt");
            //Console.WriteLine(rawCSV);

            // Read the contents of the CSV files as individual lines
            string[] productData = System.IO.File.ReadAllLines(@"C:\Users\B053643\source\repos\ProductRecommender\Data\Products.txt");
            string[] userSessionData = System.IO.File.ReadAllLines(@"C:\Users\B053643\source\repos\ProductRecommender\Data\CurrentUserSession.txt");
            string[] userHistory = System.IO.File.ReadAllLines(@"C:\Users\B053643\source\repos\ProductRecommender\Data\CurrentUserSession.txt");

            // Create lists with the product.txt data
            var movieId = new List<string>();
            var keywood1 = new List<string>();
            var ratings = new List<string>();
            var nameMovie = new List<string>();
            var titleAndRating = new List<string>();

            // Create lists with the User session data
            var userIdSession = new List<string>();
            var currentView = new List<string>();

            // Create lists with the User data
            var userId = new List<string>();
            var previousViews = new List<string>();
            var previousBuys = new List<string>();


            // Split each row into column data
            for (int i = 0; i < productData.Length; i++)
            {
                string[] rawProductData = productData[i].Split(',');

                // Product data                   
                movieId.Add(rawProductData[0]);
                nameMovie.Add(rawProductData[1]);
                keywood1.Add(rawProductData[3]);
                ratings.Add(rawProductData[8]);


            }

            for (int i = 0; i < userSessionData.Length; i++)
            {

                string[] rawSessionData = userSessionData[i].Split(',');

                // User session data
                userIdSession.Add(rawSessionData[0]);
                currentView.Add(rawSessionData[1]);

            }

            for (int i = 0; i < userHistory.Length; i++)
            {

                string[] rawUserData = userHistory[i].Split(',');

                // User data
                userId.Add(rawUserData[0]);
                previousViews.Add(rawUserData[1]);
                previousBuys.Add(rawUserData[2]);

            }


            //var top5 = ratings.OrderByDescending(i => i).Take(5);
            //for (int i = 0; i < top5.Count(); i++)
            //{
            //    //Console.Write(rowData[i]);
            //    Console.WriteLine(top5.ElementAt(i));

            //}



            //Console.WriteLine(top5.ToList());

            Console.WriteLine("Previous Views: ");
            for (int i = 0; i < userId.Count; i++)
            {

                Console.WriteLine(userId[i]);
            }


        }

    }


}