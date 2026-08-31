// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.BlockItem`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
public abstract class BlockItem<T> : BlockItem
{
  public override Type[] BlockTypes { get; }

  public sealed override Type OriginType { get; }
}
