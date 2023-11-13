using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.JSInterop;
using Oogarts.Domain.Chats;

namespace Oogarts.Client.Shared
{
    public partial class Chatbot
    {
        private List<Chat> chats = new();
        private List<Chat> responses = new();

        private bool isChatbotOpen = false;
        private bool ShowChatGreeting
        {
            get
            {
                if (localStorage.ContainKey("showChatGreeting"))
                    return localStorage.GetItem<bool>("showChatGreeting");

                ShowChatGreeting = true;
                return ShowChatGreeting;
            }
            set
            {
                localStorage.SetItem<bool>("showChatGreeting", value);
            }
        }


        public Chatbot()
        {
            AddMockData();
        }

        private void AddMockData()
        {
            chats.Add(new Chat("HALLO") { Id = 1 } );
            responses.Add(new Chat("HALLO HOE GAAT HET") { Id = 2 });
            responses.Add(new Chat("HALLO") { Id = 3 });
        }

        private void ToggleChatbotState()
        {
            isChatbotOpen = !isChatbotOpen;
            ShowChatGreeting = false;
        }

        private void AddBotResponse(int previousId)
        {
            Chat? c = this.responses.Find(i => i.Id == previousId);

            if (c is null)
                return;

            responses = new();
            chats.Add(c);

            // TODO: Get single response from db where previous.Id equals Id
            Chat response = new($"Antwoord op \"{c.Message}\"") { Id = c.Id + 1 };
            chats.Add(response);

            AddUserResponses(response.Id);
        }

        private void AddUserResponses(int previousId)
        {
            // TODO: Get responses from db where previous.Id equals Id
            Chat? c = this.chats.Last();

            if (c is null)
                return;

            // TODO: Get single response from db where previous.Id equals Id
            responses.Add(new($"Help nee ik snap niet wat u bedoelt met \"{c.Message}\"") { Id = c.Id + 1 });
            responses.Add(new($"Ok bedankt") { Id = c.Id + 2 });
        }
    }
}
