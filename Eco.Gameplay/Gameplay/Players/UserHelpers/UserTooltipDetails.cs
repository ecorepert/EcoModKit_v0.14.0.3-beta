// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserHelpers.UserTooltipDetails
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Players.UserHelpers;

/// <summary>Helper class to separate main users information from additional one, so we can for separate tooltip for it.</summary>
[Serialized]
public class UserTooltipDetails : 
  IController,
  IViewController,
  IHasUniversalID,
  IHasSerializableID,
  ILinkable,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  [Notify]
  public 
  #nullable disable
  User User { get; }

  public LocString UILinkContent();

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  public UserTooltipDetails();

  public UserTooltipDetails(User user);

  public void SetUser(User user);

  [DoNotNotify]
  public ref int ControllerID { get; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public virtual event PropertyChangedEventHandler PropertyChanged;
}
