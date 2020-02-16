namespace ChainOfResponsibilityModel
{
    class EmployeeAuthorizationHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Employee")
            {
                return $"EmployeeAuthorizationHandler handeled the autorization of {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
