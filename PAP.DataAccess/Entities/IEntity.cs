using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAP.DataAccess.Entities
{
    internal interface IEntity
    {
        string UniqueIdentifier { get; set; }
    }
}
