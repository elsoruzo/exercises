namespace ChainOfResponsibilityModel
{
    class HrAutorizationHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Hr")
            {
                return $"HrAutorizationHandler handeled the autorization of {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
