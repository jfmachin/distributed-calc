namespace eventbus.Events {
    public class OperationEvent: BaseEvents {
        public int N1 { get; set; }
        public int N2 { get; set; }
        public string operation { get; set; }
    }
}
