namespace Satochat.Shared.Event {
    public interface IEvent {
        string GetUuid();
        string GetName();
        string GetData();
    }
}
