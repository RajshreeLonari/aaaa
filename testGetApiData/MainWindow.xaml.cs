using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using json = Newtonsoft.Json;

namespace testGetApiData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetData();
        }


       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GetData();
            //const string APPID = "";
            //string cityName = "Nashik";
            ////  public const string APP_ID = "f1a1e94eb75260c7124cfd492eee1ccb";
            ////api.openweathermap.org/data/2.5/weather?q=London
            //string SubKey = "f1a1e94eb75260c7124cfd492eee1ccb";
            //WebClient client = new WebClient();


            // string DecryptData=json.JsonConvert.DeserializeObject<RETSaveResponse>(TEMP);
        }
        public string GetOnButtonClick()
        {
            var dic = new Dictionary<string, string>();
            dic.Add("q", "Nashik,ind");
            dic.Add("APPID", "f1a1e94eb75260c7124cfd492eee1ccb");

            String Url = "https://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=f1a1e94eb75260c7124cfd492eee1ccb";
            //String Url =   "api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=f1a1e94eb75260c7124cfd492eee1ccb";

            WebClient client = new WebClient();
            client.UseDefaultCredentials = true;
            try
            {
                //client.Headers.Add("username", "Aaxpp7565_k");
                //client.Headers.Add("Content-Type", "application/json");
                //client.Headers.Add("ip-usr", "192.168.1.103");
                //client.Headers.Add("client-secret", "e43c4f14263645abbd52609fbf1b4022");
                //client.Headers.Add("txn", "2cac9e96f48144d38c935b4489724d5f");
                //client.Headers.Add("clientid", "l7xx74a7603fde584c8ca774ac763a7eec73");
                //client.Headers.Add("state-cd", "27");
                //client.Headers.Add("gstin", "27AAXPP7565Q1Z8");
                //client.Headers.Add("Ocp-Apim-Subscription-Key", "ALPRD3q3b4p4m0d3l9J4");// "d716655482854ef289561a0dddfe784b");
                //client.Headers.Add("auth-token", "734c6b8af97c4efc86b4f5942d31090a");
                //client.Headers.Add("ret_period", "092017");

            }
            catch (Exception ex)
            {
                throw;
            }
            var TEMP = client.DownloadString(Url);
            while (TEMP == "" || TEMP == null)
            {
                TEMP = client.DownloadString(Url);
            }
            return TEMP;
        }
        public void GetData()
        {
            string getdata = GetOnButtonClick();
            RetResponse b2b = JsonConvert.DeserializeObject<RetResponse>(getdata);
            //List<Weather> weath = new List<Weather>();
            foreach (var item in b2b.weather)
            {
                LblId.Content ="WEATHER ID "+ item.id;
                LblName.Content = "WEATHER MAIN " + item.main;
                LblDesc.Content= "WEATHER DESCRIPTION " + item.description;
            }

            LblResult.Content ="BASE "+ b2b.@base;
            LblWind.Content = "WIND "+b2b.wind.speed ;
            LblRain.Content = "RAIN "+b2b.rain.__invalid_name__3h;
            LblClouds.Content = "CLOUDS "+b2b.clouds.all ;

        }
        //public string DecryptData(RETSaveResponse request)
        //{
            
        //    try
        //    {
        //        #region Saperate out code
        //        //var rec = EncryptionUtils.AesDecrypt(request.rek, singleton.ek);
        //        //var data = EncryptionUtils.AesDecrypt(request.data, rec);
        //        //var data1 = Convert.ToBase64String(data);
        //        //var data2 = Convert.FromBase64String(data1);
        //        //var data3 = Encoding.UTF8.GetString(data2);
        //        //var data4 = Convert.FromBase64String(data3);
        //        //var data5 = Encoding.UTF8.GetString(data4);
        //        #endregion 
        //        return Encoding.UTF8.GetString(Convert.FromBase64String(Encoding.UTF8.GetString(Convert.FromBase64String(Convert.ToBase64String(EncryptionUtils.AesDecrypt(request.data, EncryptionUtils.AesDecrypt(request.rek, singleton.ek)))))));
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }

        //}
    }
}
