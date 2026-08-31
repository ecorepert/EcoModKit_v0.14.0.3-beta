// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Interactions.Interactors.InteractionTargetServerExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.SharedTypes;

#nullable disable
namespace Eco.Gameplay.Interactions.Interactors;

/// <summary>Server side accessors for InteractionTarget</summary>
public static class InteractionTargetServerExtensions
{
  public static Eco.World.Blocks.Block Block(this InteractionTarget target);

  /// <summary>If a block is selected, try casting to the given interface. If an object is selcted, try casting that.</summary>
  public static bool TryCast<T>(this InteractionTarget target, out T val);
}
