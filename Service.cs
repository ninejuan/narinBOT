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
        [Command("ban")]
        [RequireUserPermission(GuildPermission.Administrator, ErrorMessage = "You don't have the permission ``ban_member``!")]
        public async Task BanMember(IGuildUser user = null, [Remainder] string reason = null)
        {
            if (user == null)
            {
                await ReplyAsync("Please specify a user!");
                return;
            }
            if (reason == null) reason = "Not specified";

            await Context.Guild.AddBanAsync(user, 1, reason);

            var EmbedBuilder = new EmbedBuilder()
                .WithDescription($":white_check_mark: {user.Mention} was banned\n**Reason** {reason}")
                .WithFooter(footer =>
                {
                    footer
                    .WithText("User Ban Log")
                    .WithIconUrl("https://i.imgur.com/6Bi17B3.png");
                });
            Embed embed = EmbedBuilder.Build();
            await ReplyAsync(embed: embed);
        }
        [Command("kick")]
        public async Task KickMember(SocketGuildUser user = null, string reason = null)
        {
            if (user == null)
            {
                await Context.Channel.SendMessageAsync("유저를 지정해주세요!");
                return;
            }
            if (user == Context.User)
            {
                await user.SendMessageAsync($"당신은 {Context.Guild.Name}에서 추방당했습니다!");
                await Context.Guild.GetUser(user.Id).KickAsync();
                await Context.Channel.SendMessageAsync($"{user.Username}을 추방했어요!");
            }
            var userid = Context.Guild.GetUser(user.Id);
            userid.KickAsync();
        }
        /*[Command("kick")]
        [RequireBotPermission(GuildPermission.KickMembers)]
        public async Task KickAsync(IGuildUser user)
        {

            var GuildUser = Context.Guild.GetUser(Context.User.Id);

            if (!GuildUser.GuildPermissions.KickMembers)
            {
                await Context.Message.DeleteAsync();
                await ReplyAsync(":warning: `No permissions to kick players`");
                return;
            }
            else
            {
                await user.KickAsync();
                await Context.Channel.SendMessageAsync($":eye: `{user.Username} has been kicked from the server`");

                var guild = Context.Guild;
                var channel = guild.GetTextChannel(957616910365777970); //582790350620327952

                EmbedBuilder builder = new EmbedBuilder();

                builder.WithTitle("Logged Information")
                    .AddField("User", $"{user.Mention}")
                    .AddField("Moderator", $"{Context.User.Username}")
                    .AddField("Other Information", "Can be invited back")
                    .AddField("Command", $"``.kick {user.Username}``")
                    .WithDescription($"This player has been kicked from {Context.Guild.Name} by {Context.User.Username}")
                    .WithFooter($"{Context.User.Username}", Context.User.GetAvatarUrl())

                    .WithCurrentTimestamp()
                    .WithColor(new Color(54, 57, 62));
                await Context.Channel.SendMessageAsync("하이");
            }
        }*/
    }
}
