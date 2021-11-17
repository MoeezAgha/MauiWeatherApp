using Newtonsoft.Json;
using OpenWeatherAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WatherApp.Pages
{
    public partial class Index
    {

        string Message { get; set; } = "Karachi";

        private QueryResponse openWeatherModels;
        private string DateFromate;


        protected override void OnInitialized()
        {
            GetCity();
        }


        public void GetCity()
        {
            var openWeatherAPI = new OpenWeatherAPI.OpenWeatherApiClient("786592f5c32bc1aa1fd573b2466a4aad");
            var query = openWeatherAPI.Query(Message);
            openWeatherModels = query;
            DateFromate = $"{DateTime.Now.ToString("dddd")}, {DateTime.Now.ToString("dd")} {DateTime.Now.ToString("MMM")} {DateTime.Now.ToString("yyyy")}";
        }

    }

 
}
