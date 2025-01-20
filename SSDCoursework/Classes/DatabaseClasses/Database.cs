using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;

namespace SSDCoursework.Classes.DatabaseClasses
{
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
                File.Create(filePath).Close();
            }
        }

        public void AddEntry(T entry)
        {
            Entries.Add(entry);
            Write();
        }

        public void RemoveEntry(T entry)
        {
            Entries.Remove(entry);
            Write();
        }

        /// <summary>
        /// Retrieves the contents from the CSV file and updates the list.
        /// </summary>
        protected abstract void Retrieve();

        /// <summary>
        /// Updates the CSV file according to the list.
        /// </summary>
        protected abstract void Write();
    }
}