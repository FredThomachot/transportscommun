using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

namespace TransportsCommun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Public transport");

            string urlApi = "https://data.metromobilite.fr/api/linesNear/json?x=5.72792&y=45.18549&dist=800&details=true";

            WebRequest request = WebRequest.Create(urlApi);
            WebResponse response = request.GetResponse();

            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string responseFromServer = reader.ReadToEnd();

            Console.WriteLine(responseFromServer);

            JArray json = JArray.Parse(responseFromServer);






        }
    }
}
