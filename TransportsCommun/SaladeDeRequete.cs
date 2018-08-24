using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace TransportsCommun
{
    class SaladeDeRequete
    {
        string urlApi = "https://data.metromobilite.fr/api/linesNear/json?x=5.72792&y=45.18549&dist=800&details=true";

        //Constructeur ->
        public SaladeDeRequete()
        {
        }

        public string gimmeTomato()
        {
            //On fait la requête 
            WebRequest request = WebRequest.Create(urlApi);
            WebResponse response = request.GetResponse();

            //On recup le stream
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            //On passe le stream en string
            string responseFromServer = reader.ReadToEnd();

            //Console.WriteLine(responseFromServer);

            return responseFromServer;
        }





    }
}
