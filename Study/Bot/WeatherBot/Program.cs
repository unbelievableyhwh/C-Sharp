using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;

namespace WeatherBot
{
    class Program
    {
        private static string _token { get; set; } = "2119403237:AAGhQ_Tk5ekuQhM0D2lDycWTG2j1h95W5lE";
        private static TelegramBotClient _client;

        static string nameCity;
        static float tempOfCity;
        static string nameOfCity;

        static string answerOnWeather;
        static void Main(string[] args)
        {
            _client = new TelegramBotClient(_token) { Timeout = TimeSpan.FromSeconds(10) };
            var me = _client.GetMeAsync().Result;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Bot_id: {me.Id} \nBot_Name: {me.FirstName}");
            _client.StartReceiving();
            _client.OnMessage += Bot_OnMessage;
            Console.ReadLine();
            _client.StopReceiving();
        }
        private static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            var message = e.Message;

            if(message.Type == MessageType.Text)
            {
                nameCity = message.Text;
                Weather(nameCity);
                Celsius(tempOfCity);
                await _client.SendTextMessageAsync(message.Chat.Id, $"{answerOnWeather} \n\nТемпература в {nameOfCity}: {Math.Round(tempOfCity)} °C");

                Console.WriteLine(message.Text);
            }
        }
        private static void Weather(string cityName)
        {
            try
            {
                string url = "https://api.openweathermap.org/data/2.5/weather?q=" + cityName + "&unit=metric&appid=c865373cfbdbb926b049d84c6d9882eb";
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest?.GetResponse();
                string response;

                using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                {
                    response = streamReader.ReadToEnd();
                }
                WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                nameOfCity = weatherResponse.Name;
                tempOfCity = weatherResponse.Main.Temp - 273;
            }
            catch(WebException)
            {
                Console.WriteLine("Exception");
                return;
            }
        }

        public static void Celsius(float celsius)
        {
            if (celsius < 0)
                answerOnWeather = "Сегодня холодно, одевайся теплее!\U000E29D8";
            else if (celsius == 0)
                answerOnWeather = "Нулевая температура, стоит одеться теплее!\U0001F62C";
            else if (celsius > 0)
                answerOnWeather = "Тепло, но есть шанс заболеть\U0001F637";
            else if (celsius > 5)
                answerOnWeather = "Достаточно тепло\U000E2988";
        }
    }
}
