// Decompiled with JetBrains decompiler
// Type: Eco.Shared.States.AnimationEmoteHelper
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.States;

/// <summary>Holds data about animation emotes that's needed on the client.</summary>
public class AnimationEmoteHelper
{
  /// <summary>Emotes in this list behave improperly when on uneven ground and avatar IK is enabled, client disables IK while playing these emotes.</summary>
  public static List<AnimationEmote> EmotesWithoutIK { get; }
}
