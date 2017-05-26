using Newtonsoft.Json;
using Store.src.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Store.src.control
{
    class Reciever
    {
        private static Reciever instance;

        private Reciever() { }

        public static Reciever Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Reciever();
                }
                return instance;
            }
        }

        public bool authenticate(string user, string password)
        {
            string connectionString = String.Format("http://{0}:{1}/shop-management/shop-infrastructure/authenticate?login={2}&password={3}", 
                ConnectionParams.IpAddress, ConnectionParams.Port, user, password);
            WebRequest request = WebRequest.Create(connectionString);
            request.Method = "POST";
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            Boolean result = JsonConvert.DeserializeObject<Boolean>(reader.ReadToEnd());
            reader.Close();
            dataStream.Close();
            response.Close();
            return result;
        }

        public T[] recieveData<T>(string entity, string operation)
        {
            string connectionString = String.Format("http://{0}:{1}/shop-management/shop-infrastructure/{2}/{3}",
                                    ConnectionParams.IpAddress, ConnectionParams.Port, operation, entity);
            WebRequest request = WebRequest.Create(connectionString);
            request.Method = "POST";
            request.ContentType = "application/json";
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            Models.Rootobject<T> list = JsonConvert.DeserializeObject<Models.Rootobject<T>>(reader.ReadToEnd());
            reader.Close();
            dataStream.Close();
            response.Close();
            return list.body;
        }

        public bool sendData<T>(T objectToSend, string entityName)
        {
            string connectionString = String.Format("http://{0}:{1}/shop-management/shop-infrastructure/insert/{2}",
                        ConnectionParams.IpAddress, ConnectionParams.Port, entityName);
            WebRequest request = WebRequest.Create(connectionString);
            request.Method = "POST";
            request.ContentType = "application/json";
            byte[] byteArray = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(objectToSend));
            request.ContentLength = byteArray.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(byteArray, 0, byteArray.Length);
            requestStream.Close();
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            response.Close();
            return response.StatusCode == HttpStatusCode.OK;
        }


    }
}
