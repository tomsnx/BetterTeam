using Discord;
using Discord.WebSocket;

using BetterTeam.Config;

public class Program
{
    public static Task Main(string[] args) => new Program().BotConnectionAsync();

    // Initialize objects && variables
    private const string PATH = "Config/config.json";

    private DiscordSocketClient client;
    private Config config;

    // Bot Connection
    public async Task BotConnectionAsync()
    {
        client = new DiscordSocketClient();
        config = new Config(PATH);

        this.client.Log += Log;

        await InstallCommandsAsync();
        
        await client.LoginAsync(TokenType.Bot, config.token);
        await client.StartAsync();

        await Task.Delay(-1);
    }

    // Client Log
    private Task Log(LogMessage msg)
    {
        Console.WriteLine(msg.ToString());
        return Task.CompletedTask;
    }
}