using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Neighborstash.Core.Contracts;
using Neighborstash.Core.Model;
using Neighborstash.Core.Contracts;

namespace Neighborstash.Core.Services
{

    /// <summary>
    /// returns comined info from relevant repositories based on business logic
    /// </summary>
    public class UserAccountDataService
    {
        

        private readonly IMembershipRepository _membershipRepository;
        private readonly IUserRepository _userRepository;

        public UserAccountDataService(IUserRepository userRepo, IMembershipRepository memberRepo)
        {
            _membershipRepository = memberRepo;
            _userRepository = userRepo;
        }

        // TODO: Operations to get memeberiship data - from relevant repositories
    }
}
