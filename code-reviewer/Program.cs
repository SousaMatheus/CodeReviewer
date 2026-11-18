using OllamaSharp;

var agentMarkdownPath = Path.Combine("Agents", "code-reviewer.md");
var codePath = Path.Combine("Agents", "code.txt");
const string ollamaUrl = "http://localhost:11434";
const string model = "qwen2.5-coder:7b";

var handler = new HttpClientHandler();
var httpClient = new HttpClient(handler)
{
    BaseAddress = new Uri(ollamaUrl),
    Timeout = TimeSpan.FromMinutes(2)
};

var ollamaClient = new OllamaApiClient(httpClient);

var instructions = File.ReadAllBytes(agentMarkdownPath);
var code = File.ReadAllBytes(codePath);