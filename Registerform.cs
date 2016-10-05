using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;

namespace MissionPlanner
{
    public partial class Registerform : Form
    {
        String isLicensed;
        public static Splash Splash;
        bool isCodeAccepted = false;
        public Registerform()
        {
            InitializeComponent();
            MacBox.Text = GetMacAddress().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cancelRegistration_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            //registra
            /*
              WebClient client = new WebClient();
        client.Headers["Accept"] = "application/json";

        string returnedString = client.DownloadString(new Uri("http://yourwebapi.com/api/data
             */
            using (var client = new HttpClient())
            {
                String uriAuth = "http://www.flytop.it/ftm/check.php?mac=" + MacBox.Text + "&code=" + licenseBox.Text;
                var response = client.GetAsync(uriAuth).Result;
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                if (response.IsSuccessStatusCode)
                {
                    // by calling .Result you are performing a synchronous call
                    var responseContent = response.Content;
                    // by calling .Result you are synchronously reading the result
                    string responseString = responseContent.ReadAsStringAsync().Result;
                    JObject o = JObject.Parse(responseString);
                  
                   
                     isLicensed = o["authorize"].ToString();
                     if (isLicensed.Equals("1"))
                     {
                         OwnerBox.Text = o["owner"].ToString();
                         isCodeAccepted = true;
                         Properties.Settings.Default.islicensed = true;
                         Properties.Settings.Default.owner = o["owner"].ToString();
                         Properties.Settings.Default.macaddress = MacBox.Text;
                         Properties.Settings.Default.license = licenseBox.Text;
                         Properties.Settings.Default.Save();
                         MessageBox.Show("Attivazione Riuscita!");
                         this.Close();


                     }
                     else
                     {
                         isCodeAccepted = false;
                         OwnerBox.Text = o["owner"].ToString();
                        
                         Properties.Settings.Default.islicensed = false;
                         MessageBox.Show("Codice attivazione non valido!");
                         Properties.Settings.Default.Save();
                     }

                }
            }

      
       

      
        }
        public static String GetMacAddress()
        {
           String macID="";
           String hash="";

           foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider Ethernet network interfaces
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                   macID+=nic.GetPhysicalAddress().ToString();
                }
            }
            using (MD5 md5Hash = MD5.Create())
            {
                 hash = GetMd5Hash(md5Hash, macID);
            }

            return (hash.Substring(8, 8)).ToUpper(); 
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

       
    }
}
