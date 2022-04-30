using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace NarinBOT
{
    public class Study : ModuleBase<SocketCommandContext>
    {
        [Command("버튼")]
        [RequireUserPermission(GuildPermission.Administrator)]
        public async Task Button()
        {
            var btnbuild = new ComponentBuilder()
                .WithButton("click", "Test", ButtonStyle.Success);
            var button = btnbuild.Build();

            await Context.Channel.SendMessageAsync(" ", components: button);
        }
        [Command("멘션도배")]
        public async Task Mention()
        {
            int sec = 0;
            while (sec < 31) {
                await Context.Channel.SendMessageAsync(Context.Message.Author.Mention);
                sec++;
                // System.Threading.Thread.Sleep(300);
                    }
        }
    }
}
