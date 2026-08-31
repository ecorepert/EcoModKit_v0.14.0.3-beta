// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.GroundPolluterReportComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[RequireComponent(typeof (StorageComponent), null)]
[RequireComponent(typeof (StatusComponent), null)]
[NoIcon]
public class GroundPolluterReportComponent : WorldObjectComponent
{
  public override void Initialize();

  public override void Tick();

  public override void OnAfterObjectMoved();

  public override void Destroy();

  /// <summary>Pure per-type ground-pollution total of stored stacks (before retention and the pollution grace). Stored items pollute exactly as much as they would
  /// dumped in the world: a mix by its composition, anything else by its block's [PolluteGround]. Static so the dispatch can be unit-tested without a world.</summary>
  public static (float Soil, float Heavy, float Chem) ComputePollutionForStacks(
    IEnumerable<ItemStack> stacks);

  /// <summary>Whether any of these stacks feeds a ground pollution layer. Ignores the aging grace, so freshly produced waste counts too.</summary>
  public static bool StacksPolluteGround(IEnumerable<ItemStack> stacks);
}
