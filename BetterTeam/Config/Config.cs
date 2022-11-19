using System;
using System.Text.Json;
using System.Text.Json.Serialization;

using BetterTeam.ConfigModel;

namespace BetterTeam.Config
{
    public class Config {

        public string token { get; private set; }

        public Config(string path)
        {
            StreamReader streamReader = new StreamReader(path);
            string configJson = streamReader.ReadToEnd();
            ConfigModel.ConfigModel configDeserialize = JsonSerializer.Deserialize<ConfigModel.ConfigModel>(configJson)!;
            this.token = configDeserialize.token;
        }
    }
}

