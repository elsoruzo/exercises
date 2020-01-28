namespace DecoratorPratcicalExample.Models
{
    using System.Collections.Generic;
    public class ToDoService
    {
        private readonly IDbService _service;
        public ToDoService(IDbService service)
        {
            _service = service;
        }

        public bool Save(IEnumerable<ITodoEvent> model)
        {
            bool retVal = false;

            foreach (var item in model)
            {
                 retVal = _service.Save(item);
            }

            return retVal;
        }
    }
}
