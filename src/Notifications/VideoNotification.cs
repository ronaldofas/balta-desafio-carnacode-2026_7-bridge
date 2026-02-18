using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Notifications;

public class VideoNotification(IPlatformRenderer renderer, string title, string content, string videoUrl) 
    : Notification(renderer, title, content)
{
    private readonly string _videoUrl = videoUrl;

    public override void Render()
    {
        Renderer.RenderVideo(Title, Content, _videoUrl);
    }
}
