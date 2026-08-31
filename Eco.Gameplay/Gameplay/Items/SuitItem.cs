// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SuitItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
public abstract class SuitItem : ClothingItem
{
  public override string Slot { get; }

  public override bool Starter { get; }

  public virtual void Equipped(User user);

  public virtual void Tick(User user);

  [SyncToView(null, true)]
  public abstract AtmosphericResistance Resistance { get; }

  [SyncToView(null, true)]
  public abstract List<Level> Levels { get; }
}
