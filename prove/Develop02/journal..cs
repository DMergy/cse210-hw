class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void Display()
    {
        Console.WriteLine("Displaying all journal entries.");
    }
    public void Save(string file)
    {
        Console.WriteLine($"Saving journal entry to {file}.");
    }

    public void Load(string file)
    {
        Console.WriteLine("Loading journal entry.");
    }

    public void AddEntry(Entry entry)
    {

    }
    
    //Console.WriteLine("Welcome to your personal journal.  Please select one of the following choices:");
    

}


