// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.RestrictionDescriptor
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>What a restriction lets through, in the form a player reads and in the form the client can evaluate on its own.</summary>
public class RestrictionDescriptor : IEquatable<
#nullable disable
RestrictionDescriptor>
{
  [CompilerGenerated]
  protected virtual 
  #nullable enable
  Type EqualityContract { get; }

  /// <summary>Short chip text. Leave empty for rules that hold for nearly every storage and would only be noise on screen.</summary>
  public LocString Label { get; init; }

  /// <summary>Icon name, resolved client side against the tag and item icons. A name with no matching icon simply draws nothing.</summary>
  public 
  #nullable disable
  string IconName { get; init; }

  /// <summary>Tags an item may carry to be accepted. Empty when tags don't decide.</summary>
  public IEnumerable<string> Tags { get; init; }

  /// <summary>Item types accepted on top of <see cref="P:Eco.Gameplay.Items.RestrictionDescriptor.Tags" />. Empty when types don't decide.</summary>
  public IEnumerable<Type> Types { get; init; }

  public InventoryCarryRule CarryRule { get; init; }

  /// <summary>False when the fields above don't fully capture what gets refused, which keeps the client from predicting a rejection it can't be sure of.</summary>
  public bool IsPredictable { get; init; }

  /// <summary>Descriptor for a rule that takes anything carrying one of the given tags. Label and icon both come from the tags themselves.</summary>
  public static RestrictionDescriptor FromTags(
    IEnumerable<string> tags,
    string iconName = null,
    IEnumerable<Type> alsoTypes = null);

  [CompilerGenerated]
  public override 
  #nullable enable
  string ToString();

  [CompilerGenerated]
  protected virtual bool PrintMembers(StringBuilder builder);

  [CompilerGenerated]
  public static bool operator !=(RestrictionDescriptor? left, RestrictionDescriptor? right);

  [CompilerGenerated]
  public static bool operator ==(RestrictionDescriptor? left, RestrictionDescriptor? right);

  [CompilerGenerated]
  public override int GetHashCode();

  [CompilerGenerated]
  public override bool Equals(object? obj);

  [CompilerGenerated]
  public virtual bool Equals(RestrictionDescriptor? other);

  [CompilerGenerated]
  public virtual RestrictionDescriptor \u003CClone\u003E\u0024();

  [CompilerGenerated]
  protected RestrictionDescriptor(RestrictionDescriptor original);

  public RestrictionDescriptor();
}
