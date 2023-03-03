using Newtonsoft.Json;
using OpenAI_API.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OpenAI_API.ChatCompletions
{
    public class ChatCompletionRequest
    {
        /// <summary>
		/// ID of the model to use. You can use <see cref="ModelsEndpoint.GetModelsAsync()"/> to see all of your available models, or use a standard model like <see cref="Model.DavinciText"/>.
		/// </summary>
		[JsonProperty("model")]
        public string Model { get; set; } = OpenAI_API.Models.Model.GPT35Turbo;

        /// <summary>
        /// The messages to generate chat completions for, in the <a href="https://platform.openai.com/docs/guides/chat/introduction"> chat format.</a>
        /// </summary>
        [JsonProperty("messages")]
        public ChatMessage[] Messages { get; set; }

        /// <summary>
        /// Optional
        /// Defaults to 1
        /// What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.
        /// We generally recommend altering this or top_p but not both.
        /// </summary>
        [JsonProperty("temperature")]
        public float? Temperature { get; set; }

        /// <summary>
        ///  An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.
        /// We generally recommend altering this or temperature but not both.
        /// </summary>
        [JsonProperty("top_p")]
        public float? TopP { get; set; }

        /// <summary>
        /// How many chat completion choices to generate for each input message.
        /// </summary>
        [JsonProperty("n")]

        public int? N { get; set; }

        /// <summary>
        /// boolean
        /// Optional
        /// Defaults to false
        /// </summary>
        [JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// Up to 4 sequences where the API will stop generating further tokens.
        /// </summary>
        [JsonProperty("stop")]
        public string[]? Stop { get; set; }

        /// <summary>
        /// The maximum number of tokens allowed for the generated answer. By default, the number of tokens the model can return will be (4096 - prompt tokens).
        /// </summary>
        [JsonProperty("max_tokens")]
        public uint? MaxTokens { get; set; }

        [JsonProperty("presence_penalty")]
        public float? PresencePenality { get; set; }

        [JsonProperty("frequency_penalty")]
        public float? FrequencyPenality { get; set; }

    }
}

