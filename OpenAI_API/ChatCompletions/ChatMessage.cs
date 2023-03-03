using Newtonsoft.Json;

namespace OpenAI_API.ChatCompletions
{
    public class ChatMessage
    {
        [JsonProperty("role")]
        public string Role { get; set; }
        [JsonProperty("content")]
        public string Content { get; set; }

    }
}

