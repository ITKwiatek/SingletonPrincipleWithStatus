using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPrincipleWithStatus
{
    class FaultStatus
    {
        private static readonly FaultStatus _instance = new FaultStatus();
        private bool Status1;
        private bool Status2;

        public void SetStatusses(bool Status1, bool Status2)
        {
            this.Status1 = Status1;
            this.Status2 = Status2;
        }

        public bool IsAllTrue()
        {
            if(Status1 && Status2)
            {
                return true;
            }

            return false;
        }

        public bool GetStatus1()
        {
            return Status1;
        }

        public void SetStatus1(bool status)
        {
            Status1 = status;
        }

        public bool GetStatus2()
        {
            return Status2;
        }

        public void SetStatus2(bool status)
        {
            Status2 = status;
        }

        public static FaultStatus GetFaultStatus()
        {
            return _instance;
        }
    }
}
