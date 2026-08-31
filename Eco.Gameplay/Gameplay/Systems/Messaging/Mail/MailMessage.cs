// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Mail.MailMessage
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Systems.Messaging.Notifications;
using Eco.Shared.Serialization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Mail;

[Serialized]
public class MailMessage : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  [Serialized]
  public double TimeSeconds { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  public string CommonId { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  public string Text { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  public string Tag { get; set; }

  public MailMessage();

  public MailMessage(string text, string tag);

  public MailMessage(Notification notification);

  public ref int ControllerID { get; }
}
