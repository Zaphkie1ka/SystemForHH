using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1
{
    class RequestPart
    {
        private LabourSystem labourSystem;
        private int time;
        private int startTime = 0;

        public RequestPart(LabourSystem labourSystem, int time)
        {
            this.labourSystem = labourSystem;
            this.time = time;
        }
        public LabourSystem GetInstrument() 
        { 
            return labourSystem; 
        }
        public int GetTime() 
        { 
            return time; 
        }
        public void SetStartTime(int startTime) 
        { 
            this.startTime = startTime; 
        }
        public int GetStartTime() 
        { 
            return startTime; 
        }
    }
}
