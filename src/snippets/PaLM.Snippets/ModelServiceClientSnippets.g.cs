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
    using Google.Api.Gax;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>Generated snippets.</summary>
    public sealed class AllGeneratedModelServiceClientSnippets
    {
        /// <summary>Snippet for GetModel</summary>
        public void GetModelRequestObject()
        {
            // Snippet: GetModel(GetModelRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromModel("[MODEL]"),
            };
            // Make the request
            Model response = modelServiceClient.GetModel(request);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelRequestObjectAsync()
        {
            // Snippet: GetModelAsync(GetModelRequest, CallSettings)
            // Additional: GetModelAsync(GetModelRequest, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromModel("[MODEL]"),
            };
            // Make the request
            Model response = await modelServiceClient.GetModelAsync(request);
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModel()
        {
            // Snippet: GetModel(string, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            string name = "models/[MODEL]";
            // Make the request
            Model response = modelServiceClient.GetModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelAsync()
        {
            // Snippet: GetModelAsync(string, CallSettings)
            // Additional: GetModelAsync(string, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            string name = "models/[MODEL]";
            // Make the request
            Model response = await modelServiceClient.GetModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for GetModel</summary>
        public void GetModelResourceNames()
        {
            // Snippet: GetModel(ModelName, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ModelName name = ModelName.FromModel("[MODEL]");
            // Make the request
            Model response = modelServiceClient.GetModel(name);
            // End snippet
        }

        /// <summary>Snippet for GetModelAsync</summary>
        public async Task GetModelResourceNamesAsync()
        {
            // Snippet: GetModelAsync(ModelName, CallSettings)
            // Additional: GetModelAsync(ModelName, CancellationToken)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ModelName name = ModelName.FromModel("[MODEL]");
            // Make the request
            Model response = await modelServiceClient.GetModelAsync(name);
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModelsRequestObject()
        {
            // Snippet: ListModels(ListModelsRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            ListModelsRequest request = new ListModelsRequest { };
            // Make the request
            PagedEnumerable<ListModelsResponse, Model> response = modelServiceClient.ListModels(request);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Model item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsRequestObjectAsync()
        {
            // Snippet: ListModelsAsync(ListModelsRequest, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListModelsRequest request = new ListModelsRequest { };
            // Make the request
            PagedAsyncEnumerable<ListModelsResponse, Model> response = modelServiceClient.ListModelsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Model item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Model> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModels</summary>
        public void ListModels()
        {
            // Snippet: ListModels(int, string, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = ModelServiceClient.Create();
            // Initialize request argument(s)
            int pageSize = 0;
            string pageToken = "";
            // Make the request
            PagedEnumerable<ListModelsResponse, Model> response = modelServiceClient.ListModels(pageSize, pageToken);

            // Iterate over all response items, lazily performing RPCs as required
            foreach (Model item in response)
            {
                // Do something with each item
                Console.WriteLine(item);
            }

            // Or iterate over pages (of server-defined size), performing one RPC per page
            foreach (ListModelsResponse page in response.AsRawResponses())
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            }

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            pageSize = 10;
            Page<Model> singlePage = response.ReadPage(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }

        /// <summary>Snippet for ListModelsAsync</summary>
        public async Task ListModelsAsync()
        {
            // Snippet: ListModelsAsync(int, string, string, int?, CallSettings)
            // Create client
            ModelServiceClient modelServiceClient = await ModelServiceClient.CreateAsync();
            // Initialize request argument(s)
            int pageSize = 0;
            string pageToken = "";
            // Make the request
            PagedAsyncEnumerable<ListModelsResponse, Model> response = modelServiceClient.ListModelsAsync(pageSize, pageToken);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Model item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListModelsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Model item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            pageSize = 10;
            Page<Model> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Model item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
            // End snippet
        }
    }
}
