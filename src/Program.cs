using DesignPatternChallenge.Notifications;
using DesignPatternChallenge.Renderers;

Console.WriteLine("=== Sistema de Notificações com Bridge Pattern ===\n");

// 1. Notificação de Texto via Web
var textWeb = new TextNotification(new WebRenderer(), "Novo Pedido", "Você tem um novo pedido");
textWeb.Render();
Console.WriteLine();

// 2. Notificação de Texto via Mobile
var textMobile = new TextNotification(new MobileRenderer(), "Novo Pedido", "Você tem um novo pedido");
textMobile.Render();
Console.WriteLine();

// 3. Notificação de Imagem via Web
var imageWeb = new ImageNotification(new WebRenderer(), "Promoção", "50% de desconto!", "promo.jpg");
imageWeb.Render();
Console.WriteLine();

// 4. Notificação de Vídeo via Mobile
var videoMobile = new VideoNotification(new MobileRenderer(), "Tutorial", "Aprenda a usar o app", "tutorial.mp4");
videoMobile.Render();
Console.WriteLine();

// 5. Nova Combinação (Video + Desktop)
var videoDesktop = new VideoNotification(new DesktopRenderer(), "Review", "Análise do produto", "review.mp4");
videoDesktop.Render();
Console.WriteLine();

Console.WriteLine("=== BENEFÍCIOS DO BRIDGE ===");
Console.WriteLine("✓ Abstração (Notificação) separada da Implementação (Plataforma)");
Console.WriteLine("✓ 3 Tipos + 3 Plataformas = 6 Classes (em vez de 9)");
Console.WriteLine("✓ Adicionar nova plataforma não exige mudar as notificações");
Console.WriteLine("✓ Adicionar novo tipo não exige mudar as plataformas");
