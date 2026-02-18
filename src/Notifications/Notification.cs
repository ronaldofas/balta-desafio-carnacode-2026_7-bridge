using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.Notifications;

public abstract class Notification(IPlatformRenderer renderer, string title, string content)
{
    protected IPlatformRenderer Renderer = renderer;
    protected string Title = title;
    protected string Content = content;

    public abstract void Render();
}
