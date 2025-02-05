using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace SSDCoursework.Classes.DatabaseClasses
{
    internal abstract class Database<T> where T : class
    {
        public string FilePath { get; }
        public List<T> Entries { get; set; }

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
            if (!Entries.Contains(entry))
            {
                Entries.Add(entry);
                Write();
                Retrieve();
            }
            else
            {
                MessageBox.Show("Entry already exists.");
            }
        }

        public void RemoveEntry(T entry)
        {
            if (Entries.Contains(entry))
            {
                Entries.Remove(entry);
                Write();
                Retrieve();
            }
            else
            {
                MessageBox.Show("Entry already exists.");
            }
        }

        /// <summary>
        /// Retrieves the contents from the CSV file and updates the list.
        /// </summary>
        protected abstract void Retrieve();

        /// <summary>
        /// Updates the CSV file according to the list.
        /// </summary>
        public abstract void Write();
    }
}