namespace Product.Logic
{
    public class Money
    {
        private int _whole;
        private int _fraction;
        public Money(int whole, int fraction)
        {
            _whole = whole;
            _fraction = fraction;
        }
        public void SetWhole(int whole)
        {
            _whole = whole;

        }

        public void SetFraction(int fraction)
        {
            _fraction = fraction;
        }
        public static Money operator -(Money first, Money second)
        {
            int totallfirst = first._whole *100 + first._fraction;
            int totallsecond = second._whole * 100 - second._fraction;
            int difference = totallfirst - totallsecond;
            return new Money(difference/100, difference%100);

        }
        public override string ToString()
        {
            return $"{_whole}.{_fraction}";

        }



    }
   
}
