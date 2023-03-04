class PromptGenerator
{
    private List<string> prompts = new List<string>()
    {
        "What is one thing that made you proud of yourself today?",
        "What did you learned today?",
        "What are you most grateful for in your life right now?",
        "What is something you've always wanted to learn but haven't yet?",
        "What are you looking forward to tomorrow?"
    };

    public string GetRandomPrompt()
    {
        var random = new Random();
        var index = random.Next(prompts.Count);
        return prompts[index];
    }

    public void AddPrompt(string prompt)
    {
        prompts.Add(prompt);
    }
}