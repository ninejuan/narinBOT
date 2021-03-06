using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NarinBOT
{
    public class Talk : ModuleBase<SocketCommandContext>
    {
        [Command("안녕")]
        [Alias("하이", "ㅎㅇ", "gd", "잘 잤어?", "잘잤어", "안녕하세요", "하이!", "ㅎㅇ!", "잘 잤어", "잘잤어?", "안녕하세요!", "헬로우", "헬로우!", "헬로우?", "안녕하세요?",
            "하이하이", "안뇽", "안녕하신가", "만나서 반가워", "만나서 반가워!", "만나서 반가워?",
            "굿모닝", "굿모닝!", "좋은 아침!", "좋은 아침", "좋은아침", "좋은아침!", "조은아침", "hello", "hi", "hello!", "hi",
            "good morning!", "good morning", "좋은 아침 되길!", "좋은 아침 되길", "좋은아침 되길!",
            "좋은 아침이야!", "좋은 아침이야", "좋은아침이야", "좋은아침이야!", "굳모닝", "굳모닝!", "하이염", "하이염!",
            "하이염~", "안녕", "안녕!", "안녕~")]
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
        [Command("잘 가")]
        [Alias("잘가", "잘가~", "잘가!", "잘 가~", "잘 가!", "다음에 봐", "다음에 봐!", "다음에 봐~", "다음에봐",
            "다음에봐~", "다음에봐!", "담에 봐", "담에 봐!", "담에 봐~", "그럼 잘 있어", "그럼 잘 있어!", "그럼 잘 있어~",
            "그럼 잘있어", "그럼 잘있어!", "그럼 잘있어~", "ㅂㅇ", "ㅂㅇ~", "ㅂㅇ!", "ㅃ2", "ㅃ2~", "ㅃ2!", "나중에 봐",
            "나중에 봐!", "나중에 봐~", "잘 있어", "잘 있어!", "잘 있어~", "잘있어", "잘있어!", "잘있어~", "이따 봐", "이따 봐~",
            "이따 봐!", "이따봐", "이따봐!", "이따봐~", "나중에 보자", "나중에 보자!", "나중에 보자~", "나 가야 해",
            "나 가야 해~", "나 가야 해!", "나 가야해", "나 가야해~", "나 가야해!", "나 가야함", "또 만나", "또 만나!",
            "또 만나~", "또 보자!", "또 보자", "또 보자~", "바이", "바이~", "바이!", "바이바이", "바이바이!", "바이바이~",
            "나 이제 갈게", "나 이제 갈게!", "나 이제 갈게~", "나 갈게!", "나 갈게", "나 갈게~", "다시 보자", "다시 보자!",
            "다시 보자~", "다시 만나자", "다시 만나자!", "다시 만나자~", "다시 올게!", "다시 올게", "다시 올게~", "곧 올게",
            "곧 올게!", "곧 올게~", "이따 올게!", "이따 올게", "이따 올게~")]
        public async Task ByeCommand()
        {
            string byemsg = "다음에 보자!,담에 봐!,잘 가!";
            // himsg 스트링에 원하는 인사말 추가하시면 됩니다.
            string[] text = byemsg.Split(',');
            Random random = new Random();

            int index = random.Next(text.Length);

            //ModuleBase를 상속하면 Context 변수를 통해 답장을 보낼 수 있다. 
            await Context.Channel.SendMessageAsync(text[index]);
        }
        [Command("밥 뭐 먹었어?")]
        [Alias("밥 뭐 먹었어", "밥 뭐먹었어", "밥 뭐먹었어?", "밥 먹었어?", "밥 먹었어", "밥 먹었니?", "밥 먹었니", "점심 먹었어?",
            "점심 먹었어", "저녁 먹었어?", "저녁 먹었어", "식사 했어?", "식사 했어", "식사했어?", "식사했어", "밥은 먹었어?", "밥은 먹었어",
            "아침 먹었어?", "아침 먹었어", "밥 맛있었어?", "식사는 했어?", "배고파?", "배고파", "배 안고파?", "배 안고파", "뭐 먹었어",
            "뭐 먹었어?")]
        public async Task what_i_ate()
        {
            string msg = "나? 냉면 먹었어!,아직 아무것도 안 먹었어ㅠㅠ,김밥 먹었어!,그냥 미역국 먹었어!,배가 안 고파!,잘 모르겠어!";
            // himsg 스트링에 원하는 인사말 추가하시면 됩니다.
            string[] text = msg.Split(',');
            Random random = new Random();

            int index = random.Next(text.Length);

            //ModuleBase를 상속하면 Context 변수를 통해 답장을 보낼 수 있다. 
            await Context.Channel.SendMessageAsync(text[index]);
        }
        [Command("잘 지내?")]
        [Alias("잘지내?", "잘 지내", "잘지내", "요즘 잘 지내?", "요즘 잘 지내", "요즘 잘지내", "요즘 잘지내?", "어떻게 지내?",
            "어떻게 지내", "잘 지내지?", "잘 지내지", "잘 지냈냐?", "잘 지냈냐", "잘 지냇냐?", "잘 지냇냐", "잘 있었어?", "잘 있었어",
            "잘 있었니?", "잘 있었니", "잘 있었지?", "잘 있었지", "요즘 어떻게 지냈어?", "요즘 어떻게 지냈어", "어떻게 지냈어?",
            "어떻게 지냈어", "요즘 잘 지냈어?", "요즘 잘 지냈어", "요즘 잘 지내니?", "요즘 잘 지내니", "요즘 잘 지내지?",
            "요즘 잘 지내지", "요즘 잘 지내?", "요즘 잘 지내", "요즘 잘 지냉?", "요즘 잘 지냉", "잘 지내는 거지 요즘?",
            "잘 지내는 거지 요즘", "잘 지내는 거지?", "잘 지내는 거지", "별 일 없냐?", "별 일 없냐", "별 일 없어?", "별 일 없어",
            "별 일 없지?", "별 일 없지", "뭐 하구 지냈어?", "뭐 하구 지냈어", "뭐 하구 지냈니?", "뭐 하구 지냈니", "뭐 하고 지냈어?",
            "뭐 하고 지냈어", "뭐 하구 지냈엉?", "뭐 하구 지냈엉", "뭐 하구 지내?", "뭐 하구 지내", "뭐 하고 지내?", "뭐 하고 지내",
            "뭐 하고 지내니?", "뭐 하구 지내니")]
        public async Task IsLifeIsGood()
        {
            string msg = "나? 잘 지내!,조금 힘든 일이 있지만 괜찮아!,너만 괜찮으면 돼!,조금 힘들어ㅠㅠ,별 일 없어!";
            // himsg 스트링에 원하는 인사말 추가하시면 됩니다.
            string[] text = msg.Split(',');
            Random random = new Random();

            int index = random.Next(text.Length);

            //ModuleBase를 상속하면 Context 변수를 통해 답장을 보낼 수 있다. 
            await Context.Channel.SendMessageAsync(text[index]);
        }
        [Command("오랜만이야")]
        [Alias("오랜만이야!", "오랫만이야", "오랫만이야!", "오랜만!", "오랜만", "오랜만이네", "오랜만이네!", "오랜만이다!", "오랜만이다",
            "오랜만이넹", "오랜만이넹!")]
        public async Task LongTimeNoSee()
        {
            string msg = "오랜만이야!,우아! 못 본지 정말 오래됐어!,반가워!";
            // himsg 스트링에 원하는 인사말 추가하시면 됩니다.
            string[] text = msg.Split(',');
            Random random = new Random();

            int index = random.Next(text.Length);

            //ModuleBase를 상속하면 Context 변수를 통해 답장을 보낼 수 있다. 
            await Context.Channel.SendMessageAsync(text[index]);
        }
        [Command("잘 잤어?")]
        [Alias("잘 잤어", "잘잤어?", "잘잤어", "잠은 잘 잤어?", "잠은 잘 잤어?", "잠은 잘잤어?", "잠은 잘잤어", "잠은 잘 잤나요?",
            "잠은 잘 잤나요", "잠은 잘잤나요?", "잠은 잘잤나요", "잘 자또?", "잘 자또", "잘 잤닝?", "잘 잤닝", "잘 잤엉?", "잘 잤엉",
            " ")]
        public async Task AreYouGoodNight()
        {

        }
    }
}