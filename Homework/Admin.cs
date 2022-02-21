using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Admin
    {
        public bool IsSuperAdmin;
        public object Section;
        public Admin(bool issuperadmin,object section)
        {
            IsSuperAdmin = issuperadmin;
            Section = section;

        }
        public string Manager()
        {
            return $"IsSuperAdmin:{IsSuperAdmin},Section {Section}";
        }
        
    }
}
