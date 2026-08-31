// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Storage.ModularStockpileComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components.Storage;

/// <summary> This component packages up the blocks of a stockpile into a format that can be used by moving objects, such as vehicles. </summary>
[Serialized]
[RequireComponent(typeof (StockpileComponent), null)]
[Priority(-100)]
[NoIcon]
[MustBeGridAligned(IgnoreParent = true)]
public class ModularStockpileComponent : WorldObjectComponent
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  public override void Initialize();
}
