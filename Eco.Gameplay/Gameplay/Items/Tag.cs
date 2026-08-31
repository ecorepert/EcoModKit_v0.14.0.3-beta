// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Tag
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>Tags represent groups of items, for example tag "wood" can be applied to different types of wood.</summary>
[IconGroup("Tags")]
[Serialized]
public class Tag : 
  ItemRepresentation,
  IHasID,
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  IHasIcon,
  ILinkable,
  IEcopediaEntry
{
  [Serialized]
  [SyncToView(null, true)]
  public override string Name { get; set; }

  public Tag(string name);

  public LocString PluralName { get; set; }

  public LocString LocalizedName { get; set; }

  [SyncToView(null, true)]
  public string IconName { get; set; }

  [SyncToView(null, true)]
  public int Id { get; }

  [SyncToView(null, true)]
  public bool IsVisibleInFilter { get; set; }

  [SyncToView(null, true)]
  public bool IsVisibleInStore { get; set; }

  [SyncToView(null, true)]
  public bool Hidden { get; set; }

  public bool IsVisibleInEcopedia { get; set; }

  public bool IsVisibleInTooltip { get; }

  public override LocString DisplayNamePlural { get; }

  [SyncToView(null, true)]
  public override LocString DisplayName { get; }

  public void Initialize();

  public void Destroyed();

  public void ReInitialize();

  public override bool RepresentsItem(Item other);

  public override bool RepresentsItemType(Type itemType);

  public override int RepresentativeHash();

  public bool CanBeDeleted { get; }

  public static implicit operator Tag(string tagName);
}
