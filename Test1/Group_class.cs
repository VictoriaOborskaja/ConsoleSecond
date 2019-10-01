using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Group_class
    {
        public string GroupName { get; set; }

        

        

        public Group_class(string groupname)
        {
            GroupName = groupname;
            

        }

        public Group_class()
        {
        }

        public override string ToString()
        {
            return GroupName + "";
        }


    }
}
