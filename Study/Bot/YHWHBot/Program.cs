using System;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.Enums;

namespace YHWHBot
{
    class Program
    {
        const string TOKEN = "2082548605:AAE4Ij5cNSzzcTnjVAdpc3Vic_ER22ao4Ys";
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    GetMessages().Wait();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.ToString());
                }
            }
        }

        static async Task GetMessages()
        {
            TelegramBotClient bot = new TelegramBotClient(TOKEN);
            int offset = 0;
            int timeout = 0;
            try
            {
                await bot.SetWebhookAsync("");
                while (true)
                {
                    var updates = await bot.GetUpdatesAsync(offset, timeout);

                    foreach (var update in updates)
                    {
                        var message = update.Message;
                        DatabaseBot db = new DatabaseBot();
                        if (message.Text == "/start")
                        {
                            Console.WriteLine("Пользователь: \n" + message.Chat.Id + message.Chat.Username);
                            Console.WriteLine("Получено сообщение: \n" + message.Text);
                            ReplyKeyboardMarkup keyboard = new ReplyKeyboardMarkup
                            {
                                Keyboard = new[]
                                {
                                    new[] {
                                        new KeyboardButton("/start"),
                                        new KeyboardButton("/reg")
                                    },
                                    new[] {
                                        new KeyboardButton("Get my info \U00002122"),
                                        new KeyboardButton("Get Data \U0001F409")
                                    }
                                }
                            };
                            await bot.SendTextMessageAsync(message.Chat.Id, "Hello, Motherfucker! " + message.Chat.Username, ParseMode.Html, null, false, false, 0, false, keyboard);
                        }
                        if (message.Text == "/reg")
                        {
                            Console.WriteLine("Получено сообщение: \n" + message.Text);
                            if (db.Registration(message.Chat.Id.ToString(), message.Chat.Username.ToString()))
                            {
                                await bot.SendTextMessageAsync(message.Chat.Id, "User is successfully registred!");
                            }
                            else
                            {
                                await bot.SendTextMessageAsync(message.Chat.Id, "User is already registred!");
                            }
                        }
                        if(message.Text == "Get my info \U00002122")
                        {
                            Console.WriteLine("Получено сообщение: \n" + message.Text);
                            await bot.SendTextMessageAsync(message.Chat.Id, $"Your id: {message.Chat.Id}, \nYour username: {message.Chat.Username}, \nTime: {DateTime.Now}");
                        }
                        if (message.Text == "Get Data \U0001F409")
                        {
                            Console.WriteLine("Получено сообщение: \n" + message.Text);
                            if (db.Validation(message.Chat.Id.ToString(), message.Chat.Username.ToString()))
                                await bot.SendTextMessageAsync(message.Chat.Id, $"This function is not yet available!");
                            else
                                await bot.SendTextMessageAsync(message.Chat.Id, $"You must be registered");
                        }
                        offset = update.Id + 1;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
        }
    }
}
