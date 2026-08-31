// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.WasteBlockItem`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Garbage;

/// <summary>Typed variant of <see cref="T:Eco.Gameplay.Garbage.WasteBlockItem" /> that binds to a single world block type <typeparamref name="T" />.</summary>
[Serialized]
public abstract class WasteBlockItem<T> : WasteBlockItem
{
  public override Type[] BlockTypes { get; }

  public sealed override Type OriginType { get; }
}
