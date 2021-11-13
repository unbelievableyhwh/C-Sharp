using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using YHWHFinanceBot.Entities;

namespace YHWHFinanceBot
{
    [ApiController]
    [Route("api/message")]
    public class TelegramBotController : ControllerBase
    {
        private readonly TelegramBotClient _telegramBotClient;
        private readonly DataContext _context;
        public TelegramBotController(TelegramBot telegramBot)
        {
            _telegramBotClient = telegramBot.GetBot().Result;
        }

        [HttpPost]
        public async Task<IActionResult> Update([FromBody]object update)
        {
            var upd = JsonConvert.DeserializeObject<Update>(update.ToString());
            var chat = upd.Message?.Chat;
            if (chat == null)
            {
                return Ok();
            }
            var appUser = new AppUser
            {
                Username = chat?.Username,
                ChatId = chat.Id,
                FirstName = chat.FirstName,
                LastName = chat.LastName
            };
            await _context.Users.AddAsync(appUser);
            await _context.SaveChangesAsync();
            await _telegramBotClient.SendTextMessageAsync(chat.Id, "You have successfully registred!", ParseMode.Markdown);
            return Ok();
        }
    }
}
