using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ChatGPTAPI.Class;
using ChatGPTAPI.Manager;
using Newtonsoft.Json.Linq;
using OpenAI_API;

namespace ChatGPTAPI {
    class Program {
        static void Main(string[] args)
        {
            dynamic api = new Api();

            //Console.WriteLine(Examples.GetTop5CharactersFromLooneyTunes(api).Result);
            //Console.WriteLine(Examples.GetPokemonDetails(api).Result);
            //Console.WriteLine(Examples.GetDistanse(api).Result);
            //Console.WriteLine(Examples.GetAllColorsFromRainbow(api).Result);
            Console.WriteLine(Examples.AddNumbers(api).Result);
            Console.Read();
        }        
    }
}
