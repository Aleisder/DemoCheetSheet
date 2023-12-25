using Demo.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repository
{
    class Repository
    {
        public readonly TechnoServiceDatabaseContext Context = new();
    }
}
