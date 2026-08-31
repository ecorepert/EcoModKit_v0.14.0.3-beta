// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PluginModulesComponentData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>Persistent payload carried on the workbench's <see cref="T:Eco.Gameplay.Items.WorldObjectItem" /> form between pickup and re-place: the installed module per slot tag at pickup; <see cref="M:Eco.Gameplay.Components.PluginModulesComponent.Initialize" /> drains it back into the live slots on re-place. Also doubles as the tooltip section on the picked-up item -- the <see cref="M:Eco.Gameplay.Components.PluginModulesComponentData.InstalledModulesTooltip" /> method is discovered via <see cref="P:Eco.Gameplay.Items.ItemPersistentData.PersistentControllers" />. Modules are permanent in placed life (see <see cref="T:Eco.Gameplay.Items.PermanentModuleRestriction" />), but pickup-of-the-host is unrestricted -- the loadout rides along on the item.</summary>
[Serialized]
public class PluginModulesComponentData : 
  IClearRequestHandler,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  [Serialized]
  public ThreadSafeDictionary<string, Item> ModulesBySlot { get; set; }

  public bool HasDataThatCanBeCleared { get; }

  public Result TryHandleClearRequest(Player player);

  /// <summary>Tooltip section listing the modules installed on the picked-up workbench, by slot. Rendered into the item form's tooltip via <see cref="P:Eco.Gameplay.Items.ItemPersistentData.PersistentControllers" />. Empty data → empty section (no clutter on never-upgraded workbenches).</summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 13, TTCat.Controls, TTFlags.None, null, new Type[] {})]
  public LocString InstalledModulesTooltip();

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler? PropertyChanged;
}
