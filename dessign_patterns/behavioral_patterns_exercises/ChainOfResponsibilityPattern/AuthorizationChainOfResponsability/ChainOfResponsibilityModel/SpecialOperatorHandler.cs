namespace ChainOfResponsibilityModel
{
    class SpecialOperatorHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "SpecialOperator")
            {
                return $"SpecialOperatorHandler handeled the autorization of {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
