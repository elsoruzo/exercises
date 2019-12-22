using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_exercises.BehavioralPatterns.ChainOfResponsibilityModel
{
    class SquirrelHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Nut")
            {
                return $"Squirrel: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
