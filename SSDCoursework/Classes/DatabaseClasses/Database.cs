using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;

internal abstract class Database<T>
{
    public string FilePath { get; }
    public List<T> Entries { get; }

    protected Database(string filePath)
    {
        FilePath = filePath;
        Entries = new List<T>();
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File not found: {filePath}. Initializing with an empty database.");
            File.Create(filePath).Close();
        }
    }

    public void AddEntry(T entry)
    {
        Entries.Add(entry);
        Write();
    }

    public void DeleteEntry(T entry)
    {
        Entries.Remove(entry);
        Write();
    }

    protected abstract void Retrieve();
    protected abstract void Write();
}
