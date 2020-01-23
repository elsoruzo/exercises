namespace DecoratorPratcicalExample.Model
{
    using System.Collections.Generic;
    public class ToDoService
    {
        IDbService _service;
        public ToDoService(IDbService service)
        {
            _service = service as IDbService;
        }

        public bool Save(IEnumerable<ITodoEvent> todoEventList)
        {
            bool operationWentOk = false;

            foreach (var todoEvent in todoEventList)
            {
                 operationWentOk = _service.Save(todoEvent);
            }

            return operationWentOk;

        }
    }
}
