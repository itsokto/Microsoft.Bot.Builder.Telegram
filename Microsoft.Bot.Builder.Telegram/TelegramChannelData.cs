using Telegram.Bot.Requests.Abstractions;

namespace Microsoft.Bot.Builder.Telegram
{
	public class TelegramChannelData<T>
	{
		public string Method { get; set; }

		public IRequest<T> Parameters { get; set; }
	}
}