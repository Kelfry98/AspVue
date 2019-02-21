using Crud.Models;
using Crud.Services.IterfaceServices.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Crud.Services.IterfaceServices
{
    public interface IPersonService: IBaseService<Person>
    {
    }
}
