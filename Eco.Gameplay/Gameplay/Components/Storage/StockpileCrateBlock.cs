// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Storage.StockpileCrateBlock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Gameplay.Components.Storage;

/// <summary> A generic block for items that aren't block items. Represented as a crate. </summary>
[Serialized]
[Transient]
[Solid]
public class StockpileCrateBlock : Block
{
}
