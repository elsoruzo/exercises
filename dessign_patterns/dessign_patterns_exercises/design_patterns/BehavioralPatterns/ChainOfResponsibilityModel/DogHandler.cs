using System;
using System.Collections.Generic;
using System.Text;

namespace design_patterns_exercises.BehavioralPatterns.ChainOfResponsibilityModel
{
    class DogHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "MeatBall")
            {
                return $"Dog: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
