using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.BL
{
  public abstract  class EntityBaseClass
    {
        public entityState Entitystate { get; set; }
        public bool isNew { get; set; }
        public bool hasChanges { get; set; }

        public bool isValid{
            get
            {
                return Validate();
            }            
        }
        public enum entityState
        {
            Active,
            Delete
        }
        public abstract bool Validate();
     
    }
}
