using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discord.Commands;

namespace BetterTeam.Modules.Commands
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task pingAsync()
        {
            await ReplyAsync("Pong!");
        }
    }
}