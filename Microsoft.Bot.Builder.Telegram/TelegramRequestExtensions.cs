using Microsoft.Bot.Schema;
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

		public static Activity CreateBotReply<T>(this ITurnContext turnContext, IRequest<T> requestBase)
		{
			var channelData = requestBase.ToChannelData();

			var reply = turnContext.Activity.CreateReply();
			reply.ChannelData = channelData;

			return reply;
		}
	}
}