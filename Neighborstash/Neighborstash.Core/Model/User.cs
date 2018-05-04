using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighborstash.Core.Model
{
    public class User : BaseModel
    {
        public int  UserId { get; set; }
        public string  Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string MiddleInitial { get; set; }
        public string DateOfBirth { get; set; }
        public char Gender { get; set; }
    }
}
