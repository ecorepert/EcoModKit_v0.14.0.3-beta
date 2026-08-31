// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.UnserializedEntry
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Core.Systems;

public abstract class UnserializedEntry : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  ILinkable
{
  public int Id;
  protected static ConcurrentDictionary<int, UnserializedEntry> idToEntry;

  public static IEnumerable<T> All<T>();

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }

  public static UnserializedEntry GetById(int id);

  public virtual void OnLinkClicked(
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  public abstract LocString UILinkContent();
}
