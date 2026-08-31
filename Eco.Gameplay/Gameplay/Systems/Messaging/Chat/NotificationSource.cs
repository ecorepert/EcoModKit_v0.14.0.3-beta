// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.NotificationSource
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Shared.Serialization;
using Eco.Shared.Services;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat;

/// <summary>
/// This class is specific for notifications, it derives from NotificationMessageSource and adds NotificationCategory
/// it allows to choose NotificationCategories in ChatTabSettings to show in chat tab
/// </summary>
[Serialized]
[DisplayName("System Source")]
public class NotificationSource : NotificationMessageSource
{
  [Serialized]
  [SyncToView(null, true)]
  public NotificationCategory Category { get; set; }

  public NotificationSource();

  public NotificationSource(NotificationCategory category);
}
