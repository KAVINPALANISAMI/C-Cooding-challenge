using PetPals_C_.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetPals_C_.Repository.Interface
{
    internal interface ICatRepository
    {
        List<Cat> PetDetails();
    }
}
