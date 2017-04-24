namespace BuckeyeStore.Core
{
    public class AggregateRating
    {
        public Thing itemReviewed { get; set; }
        public int ratingCount { get; set; }
        public int reviewCount { get; set; }
    }
}