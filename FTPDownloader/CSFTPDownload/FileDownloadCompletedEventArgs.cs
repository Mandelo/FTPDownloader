

using System;
using System.IO;

namespace CSFTPDownload
{
    public class FileDownloadCompletedEventArgs : EventArgs
    {
        public Uri ServerPath { get; set; }
        public FileInfo LocalFile { get; set; }
    }
}
