using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    public class UseCase
    {

        private string name;
        private string summary;
        private string[] actors;
        private string[] precondition;
        private string[] flow;
        private string[] exception;
        private string postcondition;


        public UseCase(string name, string summary, string[] actors, string[] precondition, string[] flow, string[] exception, string postcondition)
        {
            this.name = name;
            this.summary = summary;
            this.actors = actors;
            this.precondition = precondition;
            this.flow = flow;
            this.exception = exception;
            this.postcondition = postcondition;
        }

        public string GetName
        {
            get
            {
                return name;
            }
        }
    
        public string GetSummary
        {
            get
            {
                return summary;
            }
        }

        public string[] GetActors
        {
            get
            {
                return actors;
            }
        }

        public string[] GetPrecondition
        {
            get
            {
                return precondition;
            }
        }

        public string[] GetFlow
        {
            get
            {
                return flow;
            }
        }

        public string[] GetExceptions
        {
            get
            {
                return exception;
            }
        }

        public string GetPostcondition
        {
            get
            {
                return postcondition;
            }
        }

        public override string ToString()
        {
            return $"Use Case: {name}";
        }
    }
}