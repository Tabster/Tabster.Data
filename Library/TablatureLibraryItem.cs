#region

using System;
using System.IO;

#endregion

namespace Tabster.Data.Library
{
    public class TablatureLibraryItem
    {
        public TablatureLibraryItem(ITablatureFile file)
        {
            File = file;
        }

        public FileInfo FileInfo
        {
            get { return File.FileInfo; }
        }

        public bool Favorited { get; set; }

        public int Views { get; set; }

        public DateTime? LastViewed { get; set; }

        public DateTime Added { get; set; }

        public ITablatureFile File { get; private set; }
    }
}