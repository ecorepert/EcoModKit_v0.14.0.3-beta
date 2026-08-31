// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.BuildingWorldObjectBlock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Gameplay.Objects;

/// <summary>
/// Solid world object block used as a placeholder in occupied blocks. Marked as solid on the client, for builder purposes.
/// </summary>
[Serialized]
[Transient]
[Solid]
[Wall]
public sealed class BuildingWorldObjectBlock : WorldObjectBlock
{
  public BuildingWorldObjectBlock(WorldObject obj);
}
