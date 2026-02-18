using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Notifications;

public class TextNotification(IPlatformRenderer renderer, string title, string content) 
    : Notification(renderer, title, content)
{
    public override void Render()
    {
        Renderer.RenderText(Title, Content);
    }
}
