using System;

namespace Example.UI.Models
{
    public class ErrorViewModel
    {
        public string RequestID { get; set; }

        public bool ShowRequestID => !string.IsNullOrEmpty(RequestID);
    }
}
