// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Gameplay.Objects;

#nullable disable
namespace Eco.Gameplay.Settlements;

/// <summary>Component that has some tracking for a settlement</summary>
public abstract class SettlementComponent : WorldObjectComponent
{
  [Notify]
  [DependsOnSubMember("Parent", "CachedSettlementAtPos")]
  protected Settlement Settlement { get; }

  public override void Initialize();

  public override WorldObjectComponentClientAvailability Availability { get; }
}
