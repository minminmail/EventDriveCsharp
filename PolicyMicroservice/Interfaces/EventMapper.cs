using PolicyMicroservice;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequelClaims.PolicyMicroservice.Interfaces;
internal interface EventMapper
{
    object Map<T>(Policy policy);
}
