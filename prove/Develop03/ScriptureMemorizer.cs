public class Memorizer
{
    private List<Scripture> _scriptures;

    public Memorizer(List<Scripture> scriptures)
    {
        _scriptures = scriptures;
    }

    public void Memorize(Reference reference)
    {
        Scripture scripture = GetScripture(reference);
        if (scripture != null)
        {
            Console.WriteLine($"Memorizing {reference}...");
            Console.WriteLine(scripture.ToString());
        }
        else
        {
            Console.WriteLine($"Could not find scripture for {reference}.");
        }
    }

    private Scripture GetScripture(Reference reference)
    {
        foreach (Scripture scripture in _scriptures)
        {
            if (scripture.Reference.Equals(reference))
            {
                return scripture;
            }
        }
        return null;
    }
}

