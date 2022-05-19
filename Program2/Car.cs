using System;

namespace Program2
{
    internal class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
            //test3
        }
        public void SetOutTime()
        {
            throw new NotImplementedException();
        }
    }
}