namespace Example {
    public class CountVo {
        public int Count { private set; get; }
        public CountVo(int count) {
            Count = count;
        }
        public void Add() {
            Count++;
        }
    }
}
