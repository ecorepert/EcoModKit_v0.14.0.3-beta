// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.ChatMessageV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Gameplay.Systems.Messaging.Chat;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

public class ChatMessageV1
{
  public double Timestamp { get; }

  public string Sender { get; }

  public string Receiver { get; }

  public string Text { get; }

  public ChatMessageV1();

  public ChatMessageV1(ChatMessage message);
}
