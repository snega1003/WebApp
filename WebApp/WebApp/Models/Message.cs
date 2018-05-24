using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int IdFrom { get; set; }
        public string IdMessage { get; set; }
        public int IdTo { get; set; }
    }
}
