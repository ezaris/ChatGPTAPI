using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPTAPI.Class {
    public static class Examples {
        public static Task<string> GetTop5CharactersFromLooneyTunes(dynamic api)
        {
            var payload = new ApiPayload();
            payload.ReturnFormat.CharacterName = "String";
            payload.ReturnFormat.CharacterDescription = "String";
            payload.ReturnFormat.CharacterSlogan = "String";
            Task<string> res = api.GetTop5CharactersFromLooneyTunes(payload);
            return res;
        }

        public static Task<string> GetPokemonDetails(dynamic api)
        {
            var payload = new ApiPayload();
            payload.ReturnFormat.Index = "Int";
            payload.ReturnFormat.Name = "String";
            payload.ReturnFormat.BestAttack = "String";
            payload.Data = new List<string> { "Pikachu, Bulbasaur, Charizard" };
            Task<string> res = api.GetPokemonDetails(payload);
            return res;
        }

        public static Task<string> GetDistanse(dynamic api)
        {
            var payload = new ApiPayload();
            payload.ReturnFormat.ResultInKm = "Decimal";
            payload.Data = new List<string> { "Earth, Sun" };
            Task<string> res = api.GetDistanse(payload);
            return res;
        }

        public static Task<string> GetAllColorsFromRainbow(dynamic api)
        {
            var payload = new ApiPayload();
            payload.ReturnFormat.Color = "string";
            Task<string> res = api.GetAllColorsFromRainbow(payload);
            return res;
        }

        public static Task<string> AddNumbers(dynamic api)
        {
            var payload = new ApiPayload();
            payload.ReturnFormat.Result = "string";
            payload.Data = new List<string> { "2, 3" };            
            Task<string> res = api.AddNumbers(payload);
            return res;
        }
    }
}
