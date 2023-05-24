
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
using System.Windows.Controls;

namespace FerarimTournaments.Logic
{
    public class APIController
    {
        private const string IPADDRESS = "http://164.90.173.109:1337/";
        public static (string, string) credentials;//username, password


        #region teams
        /// <summary>
        /// Requests to join a team with the parameters passed. Returns true if successful.
        /// </summary>      
        public static bool JoinTeam(string teamName, string teamPass)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(IPADDRESS + "api/v1/teams/join");

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Credentials", credentials.Item1 + ":" + credentials.Item2);
            Console.WriteLine(credentials.Item1 + ":" + credentials.Item2);
            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\r\n\t\"name\":\"" + teamName + "\",\r\n\t\"password\":\"" + teamPass + "\"\r\n}";
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            if (httpResponse.StatusCode == HttpStatusCode.OK) return true;
            else return false;
        }


        /// <summary>
        /// Requests a team with the id passed. Returns null on fail.
        /// </summary>
        public static Team GetTeam(int id)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(IPADDRESS + "api/v1/teams/" + id);

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.Headers.Add("Credentials", credentials.Item1 + ":" + credentials.Item2);

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            Team responseObject = null;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                try
                {
                    responseObject = JsonConvert.DeserializeObject<Team>(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return responseObject;
        }

        /// <summary>
        /// Sends request to create team with the passed parameters. Returns true if successful.
        /// </summary>
        public static bool CreateTeam(string teamName, string teamPass)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(IPADDRESS + "api/v1/teams/");

            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";
            httpWebRequest.Headers.Add("Credentials", credentials.Item1 + ":" + credentials.Item2);

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\r\n\t\"name\":\"" + teamName + "\",\r\n\t\"password\":\"" + teamPass + "\"\r\n}";
                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            if (httpResponse.StatusCode == HttpStatusCode.Accepted) return true;
            else return false;
        }
        #endregion

        #region login
        public static Account GetAccount(int id)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(IPADDRESS + "api/v1/accounts/" + id);
            
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.Headers.Add("Credentials", credentials.Item1+":"+credentials.Item2);

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
        public static bool RequestRegister(string username, string firstname, string lastname, string password)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(IPADDRESS + "api/v1/accounts");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\r\n\t\"username\":\"" + username +
                    "\",\r\n\t\"firstName\":\"" + firstname +
                    "\",\r\n\t\"lastName\":\"" + lastname +
                    "\",\r\n\t\"password\":\"" + password + "\"\r\n}";
                
                Console.WriteLine(json);
                streamWriter.Write(json);
            }
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            if (httpResponse.StatusCode == HttpStatusCode.Created) return true;
            else return false;         
        }

        #endregion
    }
}
