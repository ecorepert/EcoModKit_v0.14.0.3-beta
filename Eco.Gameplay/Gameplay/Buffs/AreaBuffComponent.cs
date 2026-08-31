// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Buffs.AreaBuffComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Objects;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Buffs;

[Serialized]
public abstract class AreaBuffComponent : 
  WorldObjectComponent,
  IAreaBuffer,
  IController,
  IViewController,
  IHasUniversalID
{
  [SyncToView(null, true)]
  public bool AllowStackingBuffs { get; }

  [SyncToView(null, true)]
  public AreaDiminVal StrengthAtPos { get; }

  [SyncToView(null, true)]
  public virtual string BuffMarkedUpName { get; }

  public abstract string BoostIcons { get; }

  [SyncToView(null, true)]
  public abstract string BuffDesc { get; }

  public INamed BuffSourceObject { get; }

  [SyncToView(null, true)]
  public virtual string BuffIconName { get; }

  public List<string[]> OverlayCategories { get; }

  public override void Initialize();

  public override void Destroy();

  public abstract bool CanBuff(IBuffable buffable);

  public abstract Eco.Gameplay.Buffs.BuffDesc? ApplyBuff(IBuffable target, float strength);
}
