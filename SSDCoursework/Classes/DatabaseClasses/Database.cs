using System;
using System.Collections.Generic;
using System.IO;

internal abstract class Database<T>
{
    public string FilePath { get; }
    public List<T> Entries { get; }

    private static Database<T> instance;
    public static Database<T> Instance { get { return instance; } }

    public Database(string filePath)
    {
        FilePath = filePath;
        Entries = new List<T>();
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File not found: {filePath}. Initializing with an empty database.");
            File.Create(filePath).Close();
        }
    }

    public static void Init(Database<T> database)
    {
        if (instance == null)
        {
            instance = database;
        }
        else
        {
            throw new InvalidOperationException("Singleton instance has already been initialized.");
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