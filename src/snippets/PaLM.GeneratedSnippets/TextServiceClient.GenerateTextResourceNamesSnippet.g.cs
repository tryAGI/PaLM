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
    // [START generativelanguage_v1beta2_generated_TextService_GenerateText_sync_flattened_resourceNames]
    using Google.Ai.Generativelanguage.V1Beta2;

    public sealed partial class GeneratedTextServiceClientSnippets
    {
        /// <summary>Snippet for GenerateText</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void GenerateTextResourceNames()
        {
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
        }
    }
    // [END generativelanguage_v1beta2_generated_TextService_GenerateText_sync_flattened_resourceNames]
}
