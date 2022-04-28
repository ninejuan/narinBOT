using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NarinBOT
{
    public class Service : ModuleBase<SocketCommandContext>
    {
        [Command("찬반투표")]
        public async Task TFvote(ISocketMessageChannel channel)
        {
            var message = await channel.SendMessageAsync("I am a message.");

            // Creates a Unicode-based emoji based on the Unicode string.
            // This is effectively the same as new Emoji("💕").
            var heartEmoji = new Emoji("\U0001f495");
            // Reacts to the message with the Emoji.
            await message.AddReactionAsync(heartEmoji);

            // Parses a custom emote based on the provided Discord emote format.
            // Please note that this does not guarantee the existence of
            // the emote.
            var emote = new Emoji(":dove:");
            // Reacts to the message with the Emote.
            await message.AddReactionAsync(emote);
        }
        [Command("핑")]
        [Alias("ping", "vld")]
        public async Task Ping()
        {
            await Context.Channel.SendMessageAsync($"");
        }
    }
}
