using OpenAI_API.Chat;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTAPI.Manager {
    public class ChatGptManager {
        private OpenAI_API.OpenAIAPI api;
        public ChatGptManager()
        {
            string apiKey = ConfigurationManager.AppSettings["ChatGptApiKey"];
            api = new OpenAI_API.OpenAIAPI(apiKey);
        }

        public async Task<ChatResult> GetAnswer(string text, string format, List<string> parameters = null)
        {
            text = QueryCompiler(text, format, parameters ?? new List<string>());
            var res = await api.Chat.CreateChatCompletionAsync(text);
            return res;
        }

        private string QueryCompiler(string fnName, string format, List<string> argsJsons)
        {
            string query;
            var parameters = argsJsons.Any() ? "with parameters [" + String.Join(", ", argsJsons.ToArray()) + "]" : "without parameters";
            query = @"Return a result of an API call to the hypothetical web method \" + fnName + 
                @"\ \n" + parameters +
                @". \n\n Format response to fit following object signature: "+ format +" \n" +
            "Print just a response JSON." +
            "\n\n" +
            "If some of the input data will show in output do not modify it in any way.\n" +
            " Keep the response short. Make it a single line answer without new line characters. \n" +
            "Minify the JSON.";
            return query;
        }        
    }
}
