// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Storage.StorageProfile
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace Eco.Gameplay.Components.Storage;

/// <summary>What a storage takes and what it grants, in the form the item tooltip needs.</summary>
public class StorageProfile : IEquatable<
#nullable disable
StorageProfile>
{
  /// <summary>What a storage takes and what it grants, in the form the item tooltip needs.</summary>
  public StorageProfile(LocString Restrictions, float StackMultiplier);

  [CompilerGenerated]
  protected virtual 
  #nullable enable
  Type EqualityContract { get; }

  public LocString Restrictions { get; init; }

  public float StackMultiplier { get; init; }

  [CompilerGenerated]
  public override string ToString();

  [CompilerGenerated]
  protected virtual bool PrintMembers(StringBuilder builder);

  [CompilerGenerated]
  public static bool operator !=(StorageProfile? left, StorageProfile? right);

  [CompilerGenerated]
  public static bool operator ==(StorageProfile? left, StorageProfile? right);

  [CompilerGenerated]
  public override int GetHashCode();

  [CompilerGenerated]
  public override bool Equals(object? obj);

  [CompilerGenerated]
  public virtual bool Equals(StorageProfile? other);

  [CompilerGenerated]
  public virtual StorageProfile \u003CClone\u003E\u0024();

  [CompilerGenerated]
  protected StorageProfile(StorageProfile original);

  [CompilerGenerated]
  public void Deconstruct(out LocString Restrictions, out float StackMultiplier);
}
