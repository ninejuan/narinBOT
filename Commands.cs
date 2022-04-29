using System.Threading.Tasks;
using Discord.Commands;
using Discord.WebSocket;

namespace NarinBOT
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("핑")]
        [Alias("ping","vld")]
        public async Task Ping()
        {
            await Context.Channel.SendMessageAsync($"");
        }
        [Command("안녕")]
        [Alias("하이", "ㅎㅇ", "gd", "잘 잤어?","잘잤어","안녕하세요","하이!","ㅎㅇ!","잘 잤어","잘잤어?","안녕하세요!","헬로우","헬로우!","헬로우?","안녕하세요?",
            "하이하이","안뇽","안녕하신가","만나서 반가워","만나서 반가워!","만나서 반가워?",
            "굿모닝","굿모닝!","좋은 아침!","좋은 아침","좋은아침","좋은아침!","조은아침","hello","hi","hello!","hi",
            "good morning!","good morning")]
        public async Task HelloCommand()
        {
            string himsg = "굿모닝!,안녕!,만나서 반가워!,하암~ 너도 잘 잤어?,좋은 아침!";
            // himsg 스트링에 원하는 인사말 추가하시면 됩니다.
            string[] text = himsg.Split(',');
            Random random = new Random();

            int index = random.Next(text.Length);

            //ModuleBase를 상속하면 Context 변수를 통해 답장을 보낼 수 있다. 
            await Context.Channel.SendMessageAsync(text[index]);
        }
        
    }
}
