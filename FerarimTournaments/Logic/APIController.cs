
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;
using FerarimTournaments.Login;
using FerarimTournaments.Objects;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net.Http.Headers;

namespace FerarimTournaments.Logic
{
    public class APIController
    {
        private const string IPADDRESS = "http://164.90.173.109:1337/";

        #region login
        public static Account GetAccount(int id, string username, string password)
        {
            Console.WriteLine(IPADDRESS + "api/v1/accounts/" + id);
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(IPADDRESS + "api/v1/accounts/" + id);
            
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.Headers.Add("Credentials", username+":"+password);

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Account responseObject = null;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                try
                {
                    responseObject = JsonConvert.DeserializeObject<Account>(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return responseObject;
        }
    

        public static LoginResponse RequestLogin(string username, string password)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(IPADDRESS + "api/v1/accounts/login");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\r\n\t\"name\":\""+username+"\",\r\n\t\"password\":\""+password+"\"\r\n}";

                streamWriter.Write(json);
                Console.WriteLine(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            LoginResponse responseObject = null;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                try
                {
                    responseObject = JsonConvert.DeserializeObject<LoginResponse>(result);                    
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return responseObject;
        }
        #endregion

        #region register
        public static void RequestRegister(string username, string firstname, string lastname, string password)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(IPADDRESS + "api/v1/accounts");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                /*string json = "{\r\n\t\"username\":\"" + username +
                    "\",\r\n\t\"firstName\":\"" + firstname +
                    "\",\r\n\t\"lastName\":\"" + lastname +
                    "\",\r\n\t\"password\":\"" + password + "\"\r\n}";*/
                string json = "{\r\n\t\"username\":\"" + "biribiri" +
                    "\",\r\n\t\"firstName\":\"" + "a" +
                    "\",\r\n\t\"lastName\":\"" + "a" +
                    "\",\r\n\t\"password\":\"" + "admin" + "\"\r\n}";
                Console.WriteLine(json);


                streamWriter.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                try
                {
                    //responseObject = JsonConvert.DeserializeObject<LoginResponse>(result);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        #endregion
    }
}
