namespace Example.Domain {
    public class CountUpBr {
        readonly int max;
        public CountUpBr(int max) {
            this.max = max;
        }
        public int CountUp(CountVo count) {
            if (count.Count < max) {
                count.Add();
            }
            return count.Count;
        }
    }
}
