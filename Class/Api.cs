using ChatGPTAPI.Manager;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTAPI.Class {
    public class Api : DynamicObject {
        private static string error;

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            var payload = args[0] as ApiPayload;
            var data = payload.Data;

            result = GetContent(binder.Name, string.Join(", ", payload.ReturnFormat), data);
            return true;
        }

        class DataWrapper {
            public dynamic Data { get; set; }
        }       

        private static async Task<string> GetContent(string query, string args, List<string> parameters = null)
        {
            string response;
            try
            {
                var chatGptMaganer = new ChatGptManager();                
                var result = await chatGptMaganer.GetAnswer(query, args, parameters);                
                response = result.Choices[0].Message.Content;
            }
            catch (Exception x)
            {
                error = x.Message;
                response = error;
            }
            return response;
        }
    }
}
