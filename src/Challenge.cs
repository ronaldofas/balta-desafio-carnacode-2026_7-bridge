// DESAFIO: Sistema de Notificações Multi-Plataforma
// PROBLEMA: Um aplicativo precisa exibir notificações em diferentes plataformas (Web, Mobile, Desktop)
// com diferentes tipos de conteúdo (Texto, Imagem, Vídeo). O código atual cria uma explosão de classes
// combinando cada tipo de notificação com cada plataforma

using System;

namespace DesignPatternChallenge
{
    // Contexto: Sistema que renderiza notificações em múltiplas plataformas
    // Cada combinação de tipo + plataforma requer código específico
    
    // Problema: Explosão combinatória de classes
    // 3 tipos × 3 plataformas = 9 classes concretas!
    
    public abstract class NotificationBase
    {
        protected string title = string.Empty;
        protected string content = string.Empty;

        public NotificationBase(string title, string content)
        {
            this.title = title;
            this.content = content;
        }

        public abstract void Render();
    }

    // ========== NOTIFICAÇÕES DE TEXTO ==========
    
    public class TextNotificationWeb : NotificationBase
    {
        public TextNotificationWeb(string title, string content) : base(title, content) { }

        public override void Render()
        {
            Console.WriteLine($"[Web - HTML] <div class='notification'>");
            Console.WriteLine($"  <h3>{title}</h3>");
            Console.WriteLine($"  <p>{content}</p>");
            Console.WriteLine("</div>");
        }
    }

    public class TextNotificationMobile : NotificationBase
    {
        public TextNotificationMobile(string title, string content) : base(title, content) { }

        public override void Render()
        {
            Console.WriteLine($"[Mobile - Native] Push Notification:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Body: {content}");
            Console.WriteLine($"Icon: notification_icon.png");
        }
    }

    public class TextNotificationDesktop : NotificationBase
    {
        public TextNotificationDesktop(string title, string content) : base(title, content) { }

        public override void Render()
        {
            Console.WriteLine($"[Desktop - Toast] Windows Notification:");
            Console.WriteLine($"╔══════════════════════════╗");
            Console.WriteLine($"║ {title.PadRight(24)} ║");
            Console.WriteLine($"║ {content.PadRight(24)} ║");
            Console.WriteLine($"╚══════════════════════════╝");
        }
    }

    // ========== NOTIFICAÇÕES COM IMAGEM ==========
    
    public class ImageNotificationWeb : NotificationBase
    {
        private string imageUrl;

        public ImageNotificationWeb(string title, string content, string imageUrl) 
            : base(title, content)
        {
            this.imageUrl = imageUrl;
        }

        public override void Render()
        {
            Console.WriteLine($"[Web - HTML] <div class='notification-image'>");
            Console.WriteLine($"  <img src='{imageUrl}' />");
            Console.WriteLine($"  <h3>{title}</h3>");
            Console.WriteLine($"  <p>{content}</p>");
            Console.WriteLine("</div>");
        }
    }

    public class ImageNotificationMobile : NotificationBase
    {
        private string imageUrl;

        public ImageNotificationMobile(string title, string content, string imageUrl) 
            : base(title, content)
        {
            this.imageUrl = imageUrl;
        }

        public override void Render()
        {
            Console.WriteLine($"[Mobile - Native] Rich Push Notification:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Body: {content}");
            Console.WriteLine($"Image: {imageUrl}");
            Console.WriteLine($"Style: BigPictureStyle");
        }
    }

    public class ImageNotificationDesktop : NotificationBase
    {
        private string imageUrl;

        public ImageNotificationDesktop(string title, string content, string imageUrl) 
            : base(title, content)
        {
            this.imageUrl = imageUrl;
        }

        public override void Render()
        {
            Console.WriteLine($"[Desktop - Toast] Windows Notification with Image:");
            Console.WriteLine($"╔══════════════════════════╗");
            Console.WriteLine($"║ [IMG: {imageUrl.Substring(0, Math.Min(15, imageUrl.Length))}...]  ║");
            Console.WriteLine($"║ {title.PadRight(24)} ║");
            Console.WriteLine($"║ {content.PadRight(24)} ║");
            Console.WriteLine($"╚══════════════════════════╝");
        }
    }

    // ========== NOTIFICAÇÕES COM VÍDEO ==========
    
    public class VideoNotificationWeb : NotificationBase
    {
        private string videoUrl;

        public VideoNotificationWeb(string title, string content, string videoUrl) 
            : base(title, content)
        {
            this.videoUrl = videoUrl;
        }

        public override void Render()
        {
            Console.WriteLine($"[Web - HTML] <div class='notification-video'>");
            Console.WriteLine($"  <video src='{videoUrl}' controls></video>");
            Console.WriteLine($"  <h3>{title}</h3>");
            Console.WriteLine($"  <p>{content}</p>");
            Console.WriteLine("</div>");
        }
    }

    public class VideoNotificationMobile : NotificationBase
    {
        private string videoUrl;

        public VideoNotificationMobile(string title, string content, string videoUrl) 
            : base(title, content)
        {
            this.videoUrl = videoUrl;
        }

        public override void Render()
        {
            Console.WriteLine($"[Mobile - Native] Video Push Notification:");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Body: {content}");
            Console.WriteLine($"Video: {videoUrl}");
            Console.WriteLine($"Action: Tap to play");
        }
    }

    public class VideoNotificationDesktop : NotificationBase
    {
        private string videoUrl;

        public VideoNotificationDesktop(string title, string content, string videoUrl) 
            : base(title, content)
        {
            this.videoUrl = videoUrl;
        }

        public override void Render()
        {
            Console.WriteLine($"[Desktop - Toast] Windows Notification with Video:");
            Console.WriteLine($"╔══════════════════════════╗");
            Console.WriteLine($"║ ▶ {videoUrl.Substring(0, Math.Min(20, videoUrl.Length))}... ║");
            Console.WriteLine($"║ {title.PadRight(24)} ║");
            Console.WriteLine($"║ {content.PadRight(24)} ║");
            Console.WriteLine($"╚══════════════════════════╝");
        }
    }
}

