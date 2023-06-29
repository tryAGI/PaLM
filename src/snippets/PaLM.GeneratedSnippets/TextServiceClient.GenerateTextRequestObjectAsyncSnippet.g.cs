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
    // [START generativelanguage_v1beta2_generated_TextService_GenerateText_async]
    using Google.Ai.Generativelanguage.V1Beta2;
    using System.Threading.Tasks;

    public sealed partial class GeneratedTextServiceClientSnippets
    {
        /// <summary>Snippet for GenerateTextAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public async Task GenerateTextRequestObjectAsync()
        {
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
        }
    }
    // [END generativelanguage_v1beta2_generated_TextService_GenerateText_async]
}
