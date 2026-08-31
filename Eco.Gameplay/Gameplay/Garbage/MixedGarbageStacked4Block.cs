// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.MixedGarbageStacked4Block
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Gameplay.Blocks;
using Eco.Shared.Serialization;
using Eco.World;

#nullable disable
namespace Eco.Gameplay.Garbage;

[Serialized]
[NonSharedBlock]
[Tag("FullStack")]
public class MixedGarbageStacked4Block : MixedGarbageBlock
{
  public MixedGarbageStacked4Block();

  public MixedGarbageStacked4Block(FractionalBlockItem fractional);
}
