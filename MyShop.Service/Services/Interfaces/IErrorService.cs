using MyShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Service.Services.Interfaces
{
    public interface IErrorService
    {
        Error Create(Error error);
        void Save();
    }
}
