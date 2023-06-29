// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace GoogleCSharpSnippets
{
    using Google.Ai.Generativelanguage.V1Beta2;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedDiscussServiceClientSnippets
    {
        /// <summary>Snippet for GenerateMessage</summary>
        public void GenerateMessageRequestObject()
        {
            // Snippet: GenerateMessage(GenerateMessageRequest, CallSettings)
            // Create client
            DiscussServiceClient discussServiceClient = DiscussServiceClient.Create();
            // Initialize request argument(s)
            GenerateMessageRequest request = new GenerateMessageRequest
            {
                ModelAsModelName = ModelName.FromModel("[MODEL]"),
                Prompt = new MessagePrompt(),
                Temperature = 0F,
                CandidateCount = 0,
                TopP = 0F,
                TopK = 0,
            };
            // Make the request
            GenerateMessageResponse response = discussServiceClient.GenerateMessage(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateMessageAsync</summary>
        public async Task GenerateMessageRequestObjectAsync()
        {
            // Snippet: GenerateMessageAsync(GenerateMessageRequest, CallSettings)
            // Additional: GenerateMessageAsync(GenerateMessageRequest, CancellationToken)
            // Create client
            DiscussServiceClient discussServiceClient = await DiscussServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateMessageRequest request = new GenerateMessageRequest
            {
                ModelAsModelName = ModelName.FromModel("[MODEL]"),
                Prompt = new MessagePrompt(),
                Temperature = 0F,
                CandidateCount = 0,
                TopP = 0F,
                TopK = 0,
            };
            // Make the request
            GenerateMessageResponse response = await discussServiceClient.GenerateMessageAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateMessage</summary>
        public void GenerateMessage()
        {
            // Snippet: GenerateMessage(string, MessagePrompt, float, int, float, int, CallSettings)
            // Create client
            DiscussServiceClient discussServiceClient = DiscussServiceClient.Create();
            // Initialize request argument(s)
            string model = "models/[MODEL]";
            MessagePrompt prompt = new MessagePrompt();
            float temperature = 0F;
            int candidateCount = 0;
            float topP = 0F;
            int topK = 0;
            // Make the request
            GenerateMessageResponse response = discussServiceClient.GenerateMessage(model, prompt, temperature, candidateCount, topP, topK);
            // End snippet
        }

        /// <summary>Snippet for GenerateMessageAsync</summary>
        public async Task GenerateMessageAsync()
        {
            // Snippet: GenerateMessageAsync(string, MessagePrompt, float, int, float, int, CallSettings)
            // Additional: GenerateMessageAsync(string, MessagePrompt, float, int, float, int, CancellationToken)
            // Create client
            DiscussServiceClient discussServiceClient = await DiscussServiceClient.CreateAsync();
            // Initialize request argument(s)
            string model = "models/[MODEL]";
            MessagePrompt prompt = new MessagePrompt();
            float temperature = 0F;
            int candidateCount = 0;
            float topP = 0F;
            int topK = 0;
            // Make the request
            GenerateMessageResponse response = await discussServiceClient.GenerateMessageAsync(model, prompt, temperature, candidateCount, topP, topK);
            // End snippet
        }

        /// <summary>Snippet for GenerateMessage</summary>
        public void GenerateMessageResourceNames()
        {
            // Snippet: GenerateMessage(ModelName, MessagePrompt, float, int, float, int, CallSettings)
            // Create client
            DiscussServiceClient discussServiceClient = DiscussServiceClient.Create();
            // Initialize request argument(s)
            ModelName model = ModelName.FromModel("[MODEL]");
            MessagePrompt prompt = new MessagePrompt();
            float temperature = 0F;
            int candidateCount = 0;
            float topP = 0F;
            int topK = 0;
            // Make the request
            GenerateMessageResponse response = discussServiceClient.GenerateMessage(model, prompt, temperature, candidateCount, topP, topK);
            // End snippet
        }

        /// <summary>Snippet for GenerateMessageAsync</summary>
        public async Task GenerateMessageResourceNamesAsync()
        {
            // Snippet: GenerateMessageAsync(ModelName, MessagePrompt, float, int, float, int, CallSettings)
            // Additional: GenerateMessageAsync(ModelName, MessagePrompt, float, int, float, int, CancellationToken)
            // Create client
            DiscussServiceClient discussServiceClient = await DiscussServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName model = ModelName.FromModel("[MODEL]");
            MessagePrompt prompt = new MessagePrompt();
            float temperature = 0F;
            int candidateCount = 0;
            float topP = 0F;
            int topK = 0;
            // Make the request
            GenerateMessageResponse response = await discussServiceClient.GenerateMessageAsync(model, prompt, temperature, candidateCount, topP, topK);
            // End snippet
        }

        /// <summary>Snippet for CountMessageTokens</summary>
        public void CountMessageTokensRequestObject()
        {
            // Snippet: CountMessageTokens(CountMessageTokensRequest, CallSettings)
            // Create client
            DiscussServiceClient discussServiceClient = DiscussServiceClient.Create();
            // Initialize request argument(s)
            CountMessageTokensRequest request = new CountMessageTokensRequest
            {
                ModelAsModelName = ModelName.FromModel("[MODEL]"),
                Prompt = new MessagePrompt(),
            };
            // Make the request
            CountMessageTokensResponse response = discussServiceClient.CountMessageTokens(request);
            // End snippet
        }

        /// <summary>Snippet for CountMessageTokensAsync</summary>
        public async Task CountMessageTokensRequestObjectAsync()
        {
            // Snippet: CountMessageTokensAsync(CountMessageTokensRequest, CallSettings)
            // Additional: CountMessageTokensAsync(CountMessageTokensRequest, CancellationToken)
            // Create client
            DiscussServiceClient discussServiceClient = await DiscussServiceClient.CreateAsync();
            // Initialize request argument(s)
            CountMessageTokensRequest request = new CountMessageTokensRequest
            {
                ModelAsModelName = ModelName.FromModel("[MODEL]"),
                Prompt = new MessagePrompt(),
            };
            // Make the request
            CountMessageTokensResponse response = await discussServiceClient.CountMessageTokensAsync(request);
            // End snippet
        }

        /// <summary>Snippet for CountMessageTokens</summary>
        public void CountMessageTokens()
        {
            // Snippet: CountMessageTokens(string, MessagePrompt, CallSettings)
            // Create client
            DiscussServiceClient discussServiceClient = DiscussServiceClient.Create();
            // Initialize request argument(s)
            string model = "models/[MODEL]";
            MessagePrompt prompt = new MessagePrompt();
            // Make the request
            CountMessageTokensResponse response = discussServiceClient.CountMessageTokens(model, prompt);
            // End snippet
        }

        /// <summary>Snippet for CountMessageTokensAsync</summary>
        public async Task CountMessageTokensAsync()
        {
            // Snippet: CountMessageTokensAsync(string, MessagePrompt, CallSettings)
            // Additional: CountMessageTokensAsync(string, MessagePrompt, CancellationToken)
            // Create client
            DiscussServiceClient discussServiceClient = await DiscussServiceClient.CreateAsync();
            // Initialize request argument(s)
            string model = "models/[MODEL]";
            MessagePrompt prompt = new MessagePrompt();
            // Make the request
            CountMessageTokensResponse response = await discussServiceClient.CountMessageTokensAsync(model, prompt);
            // End snippet
        }

        /// <summary>Snippet for CountMessageTokens</summary>
        public void CountMessageTokensResourceNames()
        {
            // Snippet: CountMessageTokens(ModelName, MessagePrompt, CallSettings)
            // Create client
            DiscussServiceClient discussServiceClient = DiscussServiceClient.Create();
            // Initialize request argument(s)
            ModelName model = ModelName.FromModel("[MODEL]");
            MessagePrompt prompt = new MessagePrompt();
            // Make the request
            CountMessageTokensResponse response = discussServiceClient.CountMessageTokens(model, prompt);
            // End snippet
        }

        /// <summary>Snippet for CountMessageTokensAsync</summary>
        public async Task CountMessageTokensResourceNamesAsync()
        {
            // Snippet: CountMessageTokensAsync(ModelName, MessagePrompt, CallSettings)
            // Additional: CountMessageTokensAsync(ModelName, MessagePrompt, CancellationToken)
            // Create client
            DiscussServiceClient discussServiceClient = await DiscussServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName model = ModelName.FromModel("[MODEL]");
            MessagePrompt prompt = new MessagePrompt();
            // Make the request
            CountMessageTokensResponse response = await discussServiceClient.CountMessageTokensAsync(model, prompt);
            // End snippet
        }
    }
}
