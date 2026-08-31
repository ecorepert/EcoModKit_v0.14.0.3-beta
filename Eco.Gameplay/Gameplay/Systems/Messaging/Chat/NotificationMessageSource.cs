// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.NotificationMessageSource
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat;

/// <summary>
/// Notification sources are managed in chat manager.
/// They are read only channels that allow the player to choose what notification category to see or to show whispers in tab.
/// </summary>
[Serialized]
[DisplayName("Message Source")]
public class NotificationMessageSource : 
  INamed,
  IController,
  IViewController,
  IHasUniversalID,
  IHasReferenceableSerializableID,
  IHasSerializableID
{
  [SyncToView(null, true)]
  [DependsOnController("Name", true)]
  public LocString MarkedUpName { get; }

  [Serialized]
  [SyncToView(null, true)]
  public string Name { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public NotificationSourceType SourceType { get; protected set; }

  public NotificationMessageSource();

  public NotificationMessageSource(NotificationSourceType type);

  public ref int ControllerID { get; }
}
