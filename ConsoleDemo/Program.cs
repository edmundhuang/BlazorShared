
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using BlazorApp.Common;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            test();
        }

        private static void test()
        {
            WeatherForecast[] forecasts= JsonConvert.DeserializeObject<WeatherForecast[]>(File.ReadAllText("weather.json"));


            var result = forecasts.AsQueryable().GetPaged(1, 5);
        }

        private static void test1()
        {
            string html = "<a href='#'>{dafsdas}<b>dd</b></a><button>测试</button>";

            var doc = HTMLHelper.GetDocument(html);

            var node = doc.DocumentNode;
        }

    }

    class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }
        public int TemperatureF { get; set; }
        public string Summary { get; set; }
    }
}
