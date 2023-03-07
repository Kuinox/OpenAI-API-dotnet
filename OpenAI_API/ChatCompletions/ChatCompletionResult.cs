using Newtonsoft.Json;
using OpenAI_API.Completions;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI_API.ChatCompletions
{
    public class ChatCompletionResult : ApiResultBase
    {
        /// <summary>
		/// API token usage as reported by the OpenAI API for this request
		/// </summary>
		[JsonProperty("usage")]
        public CompletionUsage Usage { get; set; }
		[JsonProperty("choices")]
        public Choice[] Choices { get; set; }

    }

    public class Choice
    {
		[JsonProperty("index")]
        public int Index { get; set; }
		[JsonProperty("message")]
        public ChatMessage? Message { get; set; }
		[JsonProperty("finish_reason")]
        public string? FinishReason { get; set; }

        [JsonProperty("delta")]
        public ChoiceDelta? Delta { get; set; }
    }

    public class ChoiceDelta
    {
		[JsonProperty("content")]
        public string Content { get; set; }
    }
}
