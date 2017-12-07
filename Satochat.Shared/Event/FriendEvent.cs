using Newtonsoft.Json;
using System.Collections.Generic;

namespace Satochat.Shared.Event {
    public static class FriendEvent {
        public class FriendList : BaseEvent<FriendList> {
            public const string Name = "friend-list";

            public IEnumerable<string> Friends { get; set; }

            public FriendList(IEnumerable<string> friends) : base(Name) {
                Friends = new SortedSet<string>(friends);
            }

            protected override FriendList GetEvent() {
                return this;
            }
        }
    }
}
