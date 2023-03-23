using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1
{
    class Request
    {
        
        private string _job;
        private int _payment;
        private int _hoursInWeek;
        private int _type;
        public string getJob(string _job)
        {
            return _job;
        }
        public int getPayment(int _payment)
        {
            return _payment;
        }
        public int getHoursInWeek(int _hoursInWeek)
        {
            return _hoursInWeek;
        }
        public int getType(int _type)
        {
            return _type;
        }
        public Request(string _job, int _payment, int _hoursInWeek, int _type)
        {

        }
    }
}
