// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.PipeItem`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Gameplay.Pipes;

[Serialized]
[ConstructWithoutTool(true)]
[Tag("PlaceableOnWalls")]
[Tag("Constructable")]
[Tag("Pipe")]
public abstract class PipeItem<T> : BlockItem<T> where T : PipeBlock
{
  public override bool DisplayCrate { get; }
}
