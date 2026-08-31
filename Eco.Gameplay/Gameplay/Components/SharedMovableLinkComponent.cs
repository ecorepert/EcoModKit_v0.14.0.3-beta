// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.SharedMovableLinkComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary> Movable variant of <see cref="T:Eco.Gameplay.Components.SharedLinkComponent" /> for vehicles that host property-wide machinery (e.g. the shop cart). </summary>
[Serialized]
[Priority(2147483647 /*0x7FFFFFFF*/)]
[CreateComponentTabLoc("Storage", false)]
[HasIcon("StorageComponent")]
public class SharedMovableLinkComponent : MovableLinkComponent
{
  protected bool HasFullAccess(IAlias alias);

  protected override IAlias LinkSettingsAlias(IAlias alias);

  protected override bool SharesSettingsFor(IAlias alias);
}
