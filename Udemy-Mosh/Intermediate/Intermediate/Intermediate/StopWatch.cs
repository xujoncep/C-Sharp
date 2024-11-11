namespace Intermediate
{
    //public class StopWatch
    //{
    //    public readonly DateTime StartTime = DateTime.Now;
    //    private DateTime _endTime { get; set; }
    //    private DateTime _startTime { get; set; }



    //    public void Start()
    //    {
    //        _startTime = StartTime;

    //    }

    //    public DateTime Stop()
    //    {
    //        _endTime = DateTime.Now;

    //        return _endTime;
            
    //    }

    //    public TimeSpan GetTime(DateTime _startTime, DateTime _endTime)
    //    {
    //        var duiration = _startTime - _endTime;
    //        return duiration;

    //    }
    //}

    public class StopWatch
    {
    
        public DateTime StartTime { get; private set; } //this property no longer be changed

        public void Start()
        {
            StartTime = DateTime.Now;
        }
        
        // calculated property is here
        public double Duiration
        {
            get
            {
                TimeSpan timespan = DateTime.Now - StartTime;
                double time = timespan.TotalSeconds;
                return time;
            }

        }
    }
    
}
