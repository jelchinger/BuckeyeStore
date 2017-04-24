using System;

namespace BuckeyeStore.Core
{
    public class Offer
    {
        public AggregateRating aggregateRating { get; set; }
        public string areaServed { get; set; }
        public Boolean availability { get; set; }
        public DateTime availabilityEnds { get; set; }
        public DateTime availabilityStarts { get; set; }
        public string category { get; set; }
    }
}