using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Binding.Bindings.Source.Leaf;

namespace Neighborstash.Core.Model
{
    public class Journey
    {
        public Address FromAddress { get; set; }
        public Address ToAddress { get; set; }
    }
}
