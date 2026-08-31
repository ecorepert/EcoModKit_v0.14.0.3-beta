// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.SmokeComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Objects;
using Eco.Shared.Items;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[NoIcon]
public class SmokeComponent : WorldObjectComponent
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public SmokeType SmokeType { get; set; }
}
