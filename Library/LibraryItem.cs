#region

using System;
using System.IO;

#endregion

namespace Tabster.Data.Library
{
    public class LibraryItem
    {
        protected LibraryItem()
        {
        }

        protected LibraryItem(ITabsterFile file, FileInfo fileInfo)
        {
            File = file;
            FileInfo = fileInfo;
        }

        public long? ID { get; set; }
        public FileInfo FileInfo { get; private set; }
        public virtual ITabsterFile File { get; private set; }
    }
}