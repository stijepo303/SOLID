using System;
namespace SOLID.DIP
{
    public class ClientThatUsesService
    {
        private readonly IService _service;

        public ClientThatUsesService (IService service)
        {
            _service = service;
        }

        public void UseService()
        {
            _service.DoSomething();
        }
    }
}

