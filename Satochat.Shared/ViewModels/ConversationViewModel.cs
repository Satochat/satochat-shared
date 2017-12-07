using System.Collections.Generic;

namespace Satochat.Shared.ViewModels {
    public static class ConversationViewModel {
        /*public class Create : AbstractValidatedModel<CreateValidator, Create> {
            public ICollection<string> Recipients { get; set; }

            protected override Create getModel() {
                return this;
            }
        }
        
        public class CreateValidator : AbstractValidator<Create> {
            public CreateValidator() {
                RuleFor(o => o.Recipients).NotEmpty().WithMessage("There must be at least one recipient");
                RuleFor(o => o.Recipients).Must(r => {
                    var recipientUuids = new SortedSet<string>(r);
                    return recipientUuids.Count() == r.Count();
                }).WithMessage("There must be only one of each recipient");
            }
        }

        public class CreateResult {
            public string Uuid { get; set; }

            public CreateResult(string uuid) {
                Uuid = uuid;
            }
        }*/

        public class GetConversation {
            public string Uuid { get; set; }
        }

        public class GetConversationResult {
            public IEnumerable<string> Participants { get; set; }

            public GetConversationResult() { }

            public GetConversationResult(IEnumerable<string> participants) {
                Participants = participants;
            }
        }
    }
}
