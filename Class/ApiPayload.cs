using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTAPI.Class {
    public class ApiPayload {
        public List<string> Data { get; set; }  = new List<string>();
        public dynamic ReturnFormat { get; set; }  = new JObject();
    }
}
