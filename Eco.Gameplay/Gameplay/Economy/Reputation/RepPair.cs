// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Reputation.RepPair
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;
using System;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace Eco.Gameplay.Economy.Reputation;

[Serialized]
internal class RepPair : IEquatable<
#nullable disable
RepPair>
{
  public RepPair(IGivesReputation Source, IHasReputation Target);

  [CompilerGenerated]
  protected virtual 
  #nullable enable
  Type EqualityContract { get; }

  public 
  #nullable disable
  IGivesReputation Source { get; init; }

  public IHasReputation Target { get; init; }

  public RepPair();

  [CompilerGenerated]
  public override 
  #nullable enable
  string ToString();

  [CompilerGenerated]
  protected virtual bool PrintMembers(StringBuilder builder);

  [CompilerGenerated]
  public static bool operator !=(RepPair? left, RepPair? right);

  [CompilerGenerated]
  public static bool operator ==(RepPair? left, RepPair? right);

  [CompilerGenerated]
  public override int GetHashCode();

  [CompilerGenerated]
  public override bool Equals(object? obj);

  [CompilerGenerated]
  public virtual bool Equals(RepPair? other);

  [CompilerGenerated]
  public virtual RepPair \u003CClone\u003E\u0024();

  [CompilerGenerated]
  protected RepPair(RepPair original);

  [CompilerGenerated]
  public void Deconstruct(out 
  #nullable disable
  IGivesReputation Source, out IHasReputation Target);
}
