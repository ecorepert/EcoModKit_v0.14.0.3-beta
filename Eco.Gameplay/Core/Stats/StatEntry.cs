// Decompiled with JetBrains decompiler
// Type: Eco.Core.Stats.StatEntry
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Controllers;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using Eco.Stats;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Stats;

[Serialized]
public class StatEntry : 
  IController,
  IViewController,
  IHasUniversalID,
  IHasID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  ILinkable,
  IDescribable,
  IHasTags
{
  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public int Id { get; }

  [SyncToView(null, true)]
  public LocString MarkedUpName { get; }

  public void SetInfo(StatInfo info);

  [SyncToView(null, true)]
  public IEnumerable<Tag> Tags { get; set; }

  public ref int ControllerID { get; }

  public LocString Description();

  public LocString UILinkContent();

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  public void Initialize();

  public void Destroyed();

  public void ReInitialize();

  public bool CanBeDeleted { get; }
}
