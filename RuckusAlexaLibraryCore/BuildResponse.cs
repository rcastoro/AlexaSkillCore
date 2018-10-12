using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuckusAlexaLibraryCore
{
    public class BuildResponse
    {
        public SkillResponse ReturnOutputSpeech(string title, string resp, bool endSession, CardType cardType)
        {
            PlainTextOutputSpeech plainText = new PlainTextOutputSpeech();
            plainText.Type = "PlainText";
            plainText.Text = resp;
            ICard card = new SimpleCard();
            if(cardType == CardType.SimpleCard)
            {
                card = new SimpleCard();
                ((SimpleCard)card).title = title;
                ((SimpleCard)card).content = plainText.Text;
            }
            else if (cardType == CardType.LinkedAccount)
            {
                card = new LinkAccount();
            }

            Response response = new Response();
            response.ShouldEndSession = endSession;
            response.Card = card;
            response.OutputSpeech = plainText;
            SkillResponse skillResponse = new SkillResponse();
            skillResponse.Response = response;
            skillResponse.Version = "1.0";

            return skillResponse;
        }

        public SkillResponse ReturnOutputSSML(string title, string resp, bool endSession)
        {
            PlainTextOutputSpeech plainText = new PlainTextOutputSpeech();
            plainText.Type = "SSML";
            plainText.SSML = resp;
            SimpleCard card = new SimpleCard();
            card.title = title;
            card.content = "";
            Response response = new Response();
            response.ShouldEndSession = endSession;
            response.Card = card;
            response.OutputSpeech = plainText;
            SkillResponse skillResponse = new SkillResponse();
            skillResponse.Response = response;
            skillResponse.Version = "1.0";

            return skillResponse;
        }

        public SkillResponse ReturnDirective(IDirective directive, Intent intent, bool endSession)
        {

            if (directive.GetType() == typeof(DirectiveDialogOutput_Delegate))
            {
                ((DirectiveDialogOutput_Delegate)directive).type = "Dialog.Delegate";
                ((DirectiveDialogOutput_Delegate)directive).updatedIntent = intent;
            }
            else if (directive.GetType() == typeof(DirectivePurchaseOutput))
            {
                ((DirectivePurchaseOutput)directive).type = "Connections.SendRequest";
            }

            Response response = new Response();
            response.Directives.Add(directive);
            response.ShouldEndSession = endSession;
            SkillResponse skillResponse = new SkillResponse();
            skillResponse.Response = response;
            skillResponse.Version = "1.0";

            return skillResponse;
        }
    }
}
