using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCaseHelper
{
    public class Actor
    {

        private string actorName;
        private string[] actorDescription;

        public Actor(string actorName, string[] actorDescription)
        {
            this.actorName = actorName;
            this.actorDescription = actorDescription;
        }

        public string GetName
        {
            get
            {
                return actorName;
            }
        }

        public string[] GetDescription
        {
            get
            {
                return actorDescription;
            }
        }

        public override string ToString()
        {
            return $"Actor: {actorName}";
        }

    }
}
