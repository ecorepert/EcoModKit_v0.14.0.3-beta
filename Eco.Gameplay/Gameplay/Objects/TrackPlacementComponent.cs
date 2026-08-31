// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.TrackPlacementComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using PropertyChanged;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Objects;

public abstract class TrackPlacementComponent : WorldObjectComponent, IPersistentData
{
  protected abstract IEnumerable<IProposable> TrackedObjects { get; }

  protected abstract void InitializePersistentData();

  [SuppressPropertyChangedWarnings]
  protected abstract object Data { get; set; }

  public object PersistentData { get; set; }

  public bool Contains(IProposable entry);

  public override void Initialize();

  public override void PostInitialize();

  public override void Destroy();

  public override void OnPickup(Player player);

  protected void SetHost(WorldObject host);

  protected virtual void CheckValidity();

  protected virtual void CheckValidity(bool updateText);

  public abstract void ForceAdd(IProposable entry);
}
