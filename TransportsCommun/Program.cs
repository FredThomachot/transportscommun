using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace TransportsCommun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Public transport");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

            SaladeDeRequete superSalade = new SaladeDeRequete();
            string responseFromServer = superSalade.gimmeTomato();

            List<Station> maSuperListeDeStations = JsonConvert.DeserializeObject<List<Station>>(responseFromServer);

            foreach (Station station in maSuperListeDeStations)
            {
                Console.WriteLine(station.name);
            }

        }
    }
}
