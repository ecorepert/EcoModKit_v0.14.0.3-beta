// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.ICatalystUser
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Garbage;

/// <summary>Marks a world object type that consumes catalysts, which it must expose through a public static
/// <c>IEnumerable&lt;CatalystSpec&gt; Catalysts</c> property, derived from its own sorting targets or filter profiles so the two never drift apart.
/// The catalysts are static because tooltips and the ecopedia answer "which machine uses this catalyst?" before any such object exists in the world.
/// The mod assemblies target C# 9, which has no static abstract interface members, so <see cref="M:Eco.Gameplay.Garbage.CatalystRegistry.Initialize" /> enforces the property's presence.</summary>
public interface ICatalystUser
{
}
