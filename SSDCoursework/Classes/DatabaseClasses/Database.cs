using System;
using System.Collections.Generic;
using System.IO;

internal abstract class Database<T>
{
    public string FilePath { get; } //Auto-property that holds the CSV's path.
    public List<T> Entries { get; } //Auto-property that holds the list of entries.

    private static Database<T> instance; //Holds the current singleton instance.
    public static Database<T> Instance { get { return instance; } } //Readonly property that references the singleton instance.

    /// <summary>
    /// Initialises a database with the specified filePath. This includes initialising a list and CSV.
    /// </summary>
    /// <param name="filePath"></param>
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

    /// <summary>
    /// Attempts to set an instance of a database to the instance field with the database class. This succeeds if the instance field is null.
    /// </summary>
    /// <param name="database"></param>
    /// <exception cref="InvalidOperationException"></exception>
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
    
    /// <summary>
    /// Adds an entry to the database list.
    /// </summary>
    /// <param name="entry"></param>
    public void AddEntry(T entry)
    {
        Entries.Add(entry);
        Write();
    }

    /// <summary>
    /// Removes an entry from the database list.
    /// </summary>
    /// <param name="entry"></param>
    public void DeleteEntry(T entry)
    {
        Entries.Remove(entry);
        Write();
    }

    protected abstract void Retrieve();
    protected abstract void Write();
}