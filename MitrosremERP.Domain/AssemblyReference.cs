using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MitrosremERP.Domain
{
    public class AssemblyReference
    {
        private Assembly _assembly;

        public AssemblyReference()
        {
            _assembly = typeof(AssemblyReference).Assembly;
        }

        public string GetAssemblyName()
        {
            return _assembly.GetName().Name;
        }
    }
}
