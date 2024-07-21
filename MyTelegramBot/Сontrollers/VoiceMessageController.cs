using Telegram.Bot.Types;
using Telegram.Bot;

public class VoiceMessageController
{
    private readonly ITelegramBotClient _telegramClient;

    public VoiceMessageController(ITelegramBotClient telegramBotClient)
    {
        _telegramClient = telegramBotClient;
    }

    public async Task Handle(Message message, CancellationToken ct)
    {
        Console.WriteLine($"Контроллер {GetType().Name} получил сообщение");
        await _telegramClient.SendTextMessageAsync(message.Chat.Id, $"Получено голосовое сообщение", cancellationToken: ct);
    }
}