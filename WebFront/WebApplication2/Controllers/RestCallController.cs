using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Net;
using System.IO;

namespace WebApplication2.Controllers
{
    public class RestCallController : Controller
    {
        string results;
        public string Index()
        {
            string URL = "https://jagfunctionswe.azurewebsites.net/values";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";
            request.ContentType = "application/json";
            WebResponse webResponse = request.GetResponse();
            Stream webStream = webResponse.GetResponseStream();
            StreamReader responseReader = new StreamReader(webStream);

            results = responseReader.ReadToEnd();
            Console.Out.WriteLine(results);
            responseReader.Close();

            return results;
        }
    }
}