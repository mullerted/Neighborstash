using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neighborstash.Core.Model
{
    public class AccountType
    {
        public int AccountTypeId { get; set; }
        public string Description { get; set; }
        public string Typename { get; set; }
    }
    public class Account
    {
        public int AccountId { get; set; }
        public int  UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int AccountTypeId { get; set; }
        
        public DateTime CreateDate { get; set; }
        public DateTime Lastupdate { get; set; }
    }
}
