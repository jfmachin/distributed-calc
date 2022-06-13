namespace eventbus.Events {
    public class BaseEvents {
        public BaseEvents() {
            Id = Guid.NewGuid();
            CreationDate = DateTime.UtcNow;
        }

        public BaseEvents(Guid id, DateTime dateTime) {
            Id = id;
            CreationDate = dateTime;
        }
        public Guid Id { get; private set; }
        public DateTime CreationDate { get; private set; }
    }
}