using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    public class Client
    {
        private IService _service;
        public Client(IService service)
        {
            this._service = service;
        }
        public void PrintService()
        {
            this._service.PrintMessage();
        }
    }
}
