// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.RegistrarSystem.SimpleNamedOption
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Systems.RegistrarSystem;

/// <summary>Represents a basic selectable option we can pass to the client for selecting custom stuff in popups.</summary>
public class SimpleNamedOption : 
  INamed,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  ILinkable,
  IHasSerializableID
{
  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public LocString MarkedUpName { get; }

  [SyncToView(null, true)]
  public string Category { get; set; }

  public LocString LinkTitle { get; set; }

  public event PropertyChangedEventHandler PropertyChanged;

  [Notify]
  public LocString Tooltip { get; set; }

  public virtual void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public virtual LocString UILinkContent();

  public ref int ControllerID { get; }
}
