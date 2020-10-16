using System;
using System.Collections.Generic;

namespace LMSWebAPI.Models
{
    public partial class Books
    {
        public int Id { get; set; }
        public string BookCode { get; set; }
        public string BookName { get; set; }
        public int? BookCount { get; set; }
    }
}
