using System;
using AutoRest.Sdk;
using AutoRest.Sdk.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace AutoRest.Client
{
    class Program
    {
        static void Main(string[] args)
        {


    
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback =
            (sender, ClientCertificateOption, ContextMarshalException, sslPolicyErrors) =>{return true;};


            MyAPI client = new MyAPI(new Uri("http://localhost:5000"), clientHandler );
            IList<Destination> destinationList = client.ApiDestinationsGet();

            Console.WriteLine("\nAll Destination");
            foreach (Destination destination in destinationList)
            {
                Console.WriteLine($"{destination.CityName} - {destination.Airport}");
            }
            // ReadKey used that the console will not close when the code end to run.
            Console.ReadKey();
        }
    }
}
