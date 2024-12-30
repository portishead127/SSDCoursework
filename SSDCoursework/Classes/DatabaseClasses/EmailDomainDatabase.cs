using System;
using System.IO;
using System.Collections.Generic;

internal class EmailDomainDatabase : Database<string>
{
    private static EmailDomainDatabase instance;

    public EmailDomainDatabase(string filePath) : base(filePath)
    {
        if (instance != null)
        {
            throw new Exception("Instance of this class has already been created.");
        }
        instance = this;
        Retrieve();
    }

    public static EmailDomainDatabase Instance => instance;

    protected override void Retrieve()
    {
        Entries.Clear();
        string rawDomains = File.ReadAllText(FilePath);
        if (string.IsNullOrWhiteSpace(rawDomains))
        {
            Entries.AddRange(new[] { "@gmail.com", "@outlook.com", "@yahoo.com" });
        }
        else
        {
            Entries.AddRange(rawDomains.Split(','));
        }
        Write();
    }

    protected override void Write()
    {
        File.WriteAllText(FilePath, string.Join(",", Entries));
    }
}