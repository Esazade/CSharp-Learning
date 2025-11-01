using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Member
    {
        public string MemberId { get; set; }  
        public string Family { get; set; }  

        public Member(string id, string myName)
        {
            MemberId = id;
            Family = myName;
        }

        public override string ToString()
        {
            return "ID: "+MemberId+", Name: "+Family;
        }
    }
}
