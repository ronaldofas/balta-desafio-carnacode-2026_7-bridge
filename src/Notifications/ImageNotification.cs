using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Notifications;

public class ImageNotification(IPlatformRenderer renderer, string title, string content, string imageUrl) 
    : Notification(renderer, title, content)
{
    private readonly string _imageUrl = imageUrl;

    public override void Render()
    {
        Renderer.RenderImage(Title, Content, _imageUrl);
    }
}
