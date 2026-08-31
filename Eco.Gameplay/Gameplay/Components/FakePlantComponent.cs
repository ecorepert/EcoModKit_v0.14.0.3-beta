// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.FakePlantComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Objects;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[RequireComponent(typeof (PublicStorageComponent), null)]
[NoIcon]
[Priority(-100)]
public class FakePlantComponent : WorldObjectComponent
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [Serialized]
  [SyncToView(null, true)]
  public string SpeciesName { get; }

  public override void Initialize();
}
