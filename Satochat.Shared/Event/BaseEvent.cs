using System;
using Newtonsoft.Json;

namespace Satochat.Shared.Event {
    public abstract class BaseEvent<T> : IEvent {
        private readonly string _name;

        public BaseEvent(string name) {
            _name = name;
        }

        public string GetUuid() {
            throw new NotImplementedException();
        }

        public string GetData() {
            return JsonConvert.SerializeObject(GetEvent());
        }

        public string GetName() {
            return _name;
        }

        protected abstract T GetEvent();
    }
}
