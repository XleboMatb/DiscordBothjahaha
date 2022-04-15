using System;
using Discord;
using Discord.Webhook;
using Discord.WebSocket;
using System.Threading.Tasks;
using System.Threading;
using DSharpPlus.CommandsNext;
using DSharpPlus.CommandsNext.Attributes;

namespace GuidoBot123
{
    public class Class1 : BaseCommandModule
    {
       [Command("pog")]
        public async Task Poggers(CommandContext ctx)
        {
            await ctx.Channel.SendMessageAsync("poggers").ConfigureAwait(false);
        }
        
    }
}
