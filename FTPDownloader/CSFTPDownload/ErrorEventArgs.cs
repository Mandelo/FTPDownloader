
using System;

namespace CSFTPDownload
{
    public class ErrorEventArgs:EventArgs
    {
        public Exception ErrorException { get; set; }
    }
}
