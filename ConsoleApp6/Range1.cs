namespace ConsoleApp6
{
    public class Range<T> where T : IComparable<T>
    {
        public T _Min { get; set; }
        public T _Max { get; set; }
        public Range(T min, T max)
        {
            _Min = min;
            _Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(_Min) >= 0 && value.CompareTo(_Max) <= 0;
        }
        public T Length()
        {
            dynamic min = _Min;
            dynamic max = _Max;
            return max - min;
        }

    }
}