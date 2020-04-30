using Telegram.Bot.Requests.Abstractions;

namespace Microsoft.Bot.Builder.Telegram
{
	public static class TelegramRequestExtensions
	{
		public static object ToChannelData<T>(this IRequest<T> requestBase)
		{
			return new TelegramChannelData<T>
			{
				Method = requestBase.MethodName,
				Parameters = requestBase
			};
		}
	}
}