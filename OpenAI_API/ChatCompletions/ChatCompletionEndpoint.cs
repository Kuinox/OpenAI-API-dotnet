using OpenAI_API.Completions;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace OpenAI_API.ChatCompletions
{
    public class ChatCompletionEndpoint : EndpointBase
    {
        internal ChatCompletionEndpoint(OpenAIAPI api) : base(api)
        {
        }

        protected override string Endpoint => "chat/completions";

        /// <summary>
		/// Ask the API to complete the prompt(s) using the specified request.  This is non-streaming, so it will wait until the API returns the full result.
		/// </summary>
		/// <param name="request">The request to send to the API.  This does not fall back to default values specified in <see cref="DefaultCompletionRequestArgs"/>.</param>
		/// <returns>Asynchronously returns the completion result.  Look in its <see cref="CompletionResult.Completions"/> property for the completions.</returns>
		public async Task<ChatCompletionResult> CreateCompletionAsync(ChatCompletionRequest request)
        {
            return await HttpPost<ChatCompletionResult>(postData: request);
        }


        public IAsyncEnumerable<ChatCompletionResult> StreamCompletion(ChatCompletionRequest request)
        {
            request.Stream = true;
            return HttpStreamingRequest<ChatCompletionResult>(Url, HttpMethod.Post, request);
        }
    }
}
