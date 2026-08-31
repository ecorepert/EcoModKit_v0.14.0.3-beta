// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.LocString
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Localization;

[DebuggerDisplay("{DebugString}")]
public struct LocString : IComparable, IEquatable<LocString>
{
  public static readonly LocString Empty;
  internal readonly object S;
  internal readonly bool Localize;

  public LocString(string s);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static implicit operator string(LocString l);

  /// <summary>Returns not translated string. If <see cref="T:System.FormattableString" /> was used then it will be resolved to string.</summary>
  public string NotTranslated { get; }

  /// <summary>Checks if <see cref="T:Eco.Shared.Localization.LocString" /> may be inlined (resolved to string without information lose). It is <c>true</c> if the LocString shouldn't be localized and wraps string.</summary>
  public bool Inlinable { get; }

  public string DebugString { get; }

  /// <summary>If the loc string is <see cref="P:Eco.Shared.Localization.LocString.Inlinable" /> then returns inline value which then may be used for result string building.</summary>
  public bool TryGetInlineValue(out string value);

  public override string ToString();

  public int Length { get; }

  public static bool IsNullOrEmpty(LocString l);

  public LocString Trim();

  public LocString TrimEnd();

  public bool IsSet();

  public static bool operator ==(LocString left, LocString right);

  public static bool operator !=(LocString left, LocString right);

  public static LocString operator +(LocString left, LocString right);

  public static LocString operator +(string left, LocString right);

  public static LocString operator +(LocString left, string right);

  public LocString Wrap(Func<object, FormattableString> wrapper);

  public LocString Prepend(string prefix);

  public LocString Wrap(string prefix, string suffix = "");

  public LocString WrapNL(string prefix, string suffix = "");

  public LocString ApplyParams(Dictionary<string, string> customParams);

  public bool HaveUnresolvedParams();

  public int CompareTo(object obj);

  public override int GetHashCode();

  public bool Equals(LocString other);

  public override bool Equals(object other);

  public LocString ToLower();
}
