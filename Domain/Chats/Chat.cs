using Ardalis.GuardClauses;
using Oogarts.Domain.Common;

namespace Oogarts.Domain.Chats
{
    public class Chat : Entity
    {

        private string message = default!;
        public string Message 
        {
            get => message;
            set => message = Guard.Against.NullOrWhiteSpace(value, nameof(Message));
        }
        private List<Chat>? responses;
        public List<Chat>? Responses
        {
            get => responses;
            set => responses = value; // Voor lazy loading, voeg "ga terug" chat toe
        }

        private Chat? previous;
        public Chat? Previous 
        {
            get => previous;
            set => previous = value;
        }


        private Chat() { }

        public Chat(string message, Chat? previous = null, List<Chat>? responses = null)
        {
            Message = message;
            Previous = previous;
            Responses = responses;
        }
    }
}
