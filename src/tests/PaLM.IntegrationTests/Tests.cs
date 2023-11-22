using Google.Ai.Generativelanguage.V1Beta2;
using Google.Api.Gax;

namespace tryAGI.OpenAI.IntegrationTests;

[TestClass]
public class GeneralTests
{
    [TestMethod]
    public async Task ListModels()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");

        var modelServiceClient = await ModelServiceClient.CreateAsync();
        var response = modelServiceClient.ListModels(new ListModelsRequest());

        // Iterate over all response items, lazily performing RPCs as required
        foreach (var item in response)
        {
            Console.WriteLine(item);
        }
    }
    
    [TestMethod]
    public async Task GenerateText()
    {
        var textServiceClient = await TextServiceClient.CreateAsync();
        var response = await textServiceClient.GenerateTextAsync(new GenerateTextRequest
        {
            ModelAsModelName = ModelName.FromModel("text-bison-001"),
            Prompt = new TextPrompt
            {
                Text = """
You are an expert at solving word problems.

Solve the following problem:

I have three houses, each with three cats.
each cat owns 4 mittens, and a hat. Each mitten was
knit from 7m of yarn, each hat from 4m.
How much yarn was needed to make all the items?

Think about it step by step, and show your work.
""",
            },
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
        });
    }
}
