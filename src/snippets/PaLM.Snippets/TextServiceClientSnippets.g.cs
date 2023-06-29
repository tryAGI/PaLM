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
    public sealed class AllGeneratedTextServiceClientSnippets
    {
        /// <summary>Snippet for GenerateText</summary>
        public void GenerateTextRequestObject()
        {
            // Snippet: GenerateText(GenerateTextRequest, CallSettings)
            // Create client
            TextServiceClient textServiceClient = TextServiceClient.Create();
            // Initialize request argument(s)
            GenerateTextRequest request = new GenerateTextRequest
            {
                ModelAsModelName = ModelName.FromModel("[MODEL]"),
                Prompt = new TextPrompt(),
                Temperature = 0F,
                CandidateCount = 0,
                MaxOutputTokens = 0,
                TopP = 0F,
                TopK = 0,
                SafetySettings =
                {
                    new SafetySetting(),
                },
                StopSequences = { "", },
            };
            // Make the request
            GenerateTextResponse response = textServiceClient.GenerateText(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateTextAsync</summary>
        public async Task GenerateTextRequestObjectAsync()
        {
            // Snippet: GenerateTextAsync(GenerateTextRequest, CallSettings)
            // Additional: GenerateTextAsync(GenerateTextRequest, CancellationToken)
            // Create client
            TextServiceClient textServiceClient = await TextServiceClient.CreateAsync();
            // Initialize request argument(s)
            GenerateTextRequest request = new GenerateTextRequest
            {
                ModelAsModelName = ModelName.FromModel("[MODEL]"),
                Prompt = new TextPrompt(),
                Temperature = 0F,
                CandidateCount = 0,
                MaxOutputTokens = 0,
                TopP = 0F,
                TopK = 0,
                SafetySettings =
                {
                    new SafetySetting(),
                },
                StopSequences = { "", },
            };
            // Make the request
            GenerateTextResponse response = await textServiceClient.GenerateTextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GenerateText</summary>
        public void GenerateText()
        {
            // Snippet: GenerateText(string, TextPrompt, float, int, int, float, int, CallSettings)
            // Create client
            TextServiceClient textServiceClient = TextServiceClient.Create();
            // Initialize request argument(s)
            string model = "models/[MODEL]";
            TextPrompt prompt = new TextPrompt();
            float temperature = 0F;
            int candidateCount = 0;
            int maxOutputTokens = 0;
            float topP = 0F;
            int topK = 0;
            // Make the request
            GenerateTextResponse response = textServiceClient.GenerateText(model, prompt, temperature, candidateCount, maxOutputTokens, topP, topK);
            // End snippet
        }

        /// <summary>Snippet for GenerateTextAsync</summary>
        public async Task GenerateTextAsync()
        {
            // Snippet: GenerateTextAsync(string, TextPrompt, float, int, int, float, int, CallSettings)
            // Additional: GenerateTextAsync(string, TextPrompt, float, int, int, float, int, CancellationToken)
            // Create client
            TextServiceClient textServiceClient = await TextServiceClient.CreateAsync();
            // Initialize request argument(s)
            string model = "models/[MODEL]";
            TextPrompt prompt = new TextPrompt();
            float temperature = 0F;
            int candidateCount = 0;
            int maxOutputTokens = 0;
            float topP = 0F;
            int topK = 0;
            // Make the request
            GenerateTextResponse response = await textServiceClient.GenerateTextAsync(model, prompt, temperature, candidateCount, maxOutputTokens, topP, topK);
            // End snippet
        }

        /// <summary>Snippet for GenerateText</summary>
        public void GenerateTextResourceNames()
        {
            // Snippet: GenerateText(ModelName, TextPrompt, float, int, int, float, int, CallSettings)
            // Create client
            TextServiceClient textServiceClient = TextServiceClient.Create();
            // Initialize request argument(s)
            ModelName model = ModelName.FromModel("[MODEL]");
            TextPrompt prompt = new TextPrompt();
            float temperature = 0F;
            int candidateCount = 0;
            int maxOutputTokens = 0;
            float topP = 0F;
            int topK = 0;
            // Make the request
            GenerateTextResponse response = textServiceClient.GenerateText(model, prompt, temperature, candidateCount, maxOutputTokens, topP, topK);
            // End snippet
        }

        /// <summary>Snippet for GenerateTextAsync</summary>
        public async Task GenerateTextResourceNamesAsync()
        {
            // Snippet: GenerateTextAsync(ModelName, TextPrompt, float, int, int, float, int, CallSettings)
            // Additional: GenerateTextAsync(ModelName, TextPrompt, float, int, int, float, int, CancellationToken)
            // Create client
            TextServiceClient textServiceClient = await TextServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName model = ModelName.FromModel("[MODEL]");
            TextPrompt prompt = new TextPrompt();
            float temperature = 0F;
            int candidateCount = 0;
            int maxOutputTokens = 0;
            float topP = 0F;
            int topK = 0;
            // Make the request
            GenerateTextResponse response = await textServiceClient.GenerateTextAsync(model, prompt, temperature, candidateCount, maxOutputTokens, topP, topK);
            // End snippet
        }

        /// <summary>Snippet for EmbedText</summary>
        public void EmbedTextRequestObject()
        {
            // Snippet: EmbedText(EmbedTextRequest, CallSettings)
            // Create client
            TextServiceClient textServiceClient = TextServiceClient.Create();
            // Initialize request argument(s)
            EmbedTextRequest request = new EmbedTextRequest
            {
                ModelAsModelName = ModelName.FromModel("[MODEL]"),
                Text = "",
            };
            // Make the request
            EmbedTextResponse response = textServiceClient.EmbedText(request);
            // End snippet
        }

        /// <summary>Snippet for EmbedTextAsync</summary>
        public async Task EmbedTextRequestObjectAsync()
        {
            // Snippet: EmbedTextAsync(EmbedTextRequest, CallSettings)
            // Additional: EmbedTextAsync(EmbedTextRequest, CancellationToken)
            // Create client
            TextServiceClient textServiceClient = await TextServiceClient.CreateAsync();
            // Initialize request argument(s)
            EmbedTextRequest request = new EmbedTextRequest
            {
                ModelAsModelName = ModelName.FromModel("[MODEL]"),
                Text = "",
            };
            // Make the request
            EmbedTextResponse response = await textServiceClient.EmbedTextAsync(request);
            // End snippet
        }

        /// <summary>Snippet for EmbedText</summary>
        public void EmbedText()
        {
            // Snippet: EmbedText(string, string, CallSettings)
            // Create client
            TextServiceClient textServiceClient = TextServiceClient.Create();
            // Initialize request argument(s)
            string model = "models/[MODEL]";
            string text = "";
            // Make the request
            EmbedTextResponse response = textServiceClient.EmbedText(model, text);
            // End snippet
        }

        /// <summary>Snippet for EmbedTextAsync</summary>
        public async Task EmbedTextAsync()
        {
            // Snippet: EmbedTextAsync(string, string, CallSettings)
            // Additional: EmbedTextAsync(string, string, CancellationToken)
            // Create client
            TextServiceClient textServiceClient = await TextServiceClient.CreateAsync();
            // Initialize request argument(s)
            string model = "models/[MODEL]";
            string text = "";
            // Make the request
            EmbedTextResponse response = await textServiceClient.EmbedTextAsync(model, text);
            // End snippet
        }

        /// <summary>Snippet for EmbedText</summary>
        public void EmbedTextResourceNames()
        {
            // Snippet: EmbedText(ModelName, string, CallSettings)
            // Create client
            TextServiceClient textServiceClient = TextServiceClient.Create();
            // Initialize request argument(s)
            ModelName model = ModelName.FromModel("[MODEL]");
            string text = "";
            // Make the request
            EmbedTextResponse response = textServiceClient.EmbedText(model, text);
            // End snippet
        }

        /// <summary>Snippet for EmbedTextAsync</summary>
        public async Task EmbedTextResourceNamesAsync()
        {
            // Snippet: EmbedTextAsync(ModelName, string, CallSettings)
            // Additional: EmbedTextAsync(ModelName, string, CancellationToken)
            // Create client
            TextServiceClient textServiceClient = await TextServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName model = ModelName.FromModel("[MODEL]");
            string text = "";
            // Make the request
            EmbedTextResponse response = await textServiceClient.EmbedTextAsync(model, text);
            // End snippet
        }
    }
}
