// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.LocStringBuilder
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Localization;

public class LocStringBuilder
{
  public bool Empty { get; }

  /// <summary>
  /// Appends <paramref name="value" /> to <see cref="T:Eco.Shared.Localization.LocStringBuilder" />. Behavior depends on the <paramref name="value" />.
  /// If value is not localized and is plain string then it will just be added to format, but otherwise it will be added as argument.
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public LocStringBuilder Append(LocString value);

  public LocStringBuilder AppendLineNTStr(string value);

  public LocStringBuilder AppendLineNT(FormattableString value);

  public LocStringBuilder AppendLine(LocString value);

  public LocStringBuilder AppendLineIfSet(LocString value);

  /// <summary>Appends <paramref name="value" /> "as is".</summary>
  public LocStringBuilder Append(string value);

  public LocStringBuilder AppendLine(int n = 1);

  public LocStringBuilder Append(object value);

  public LocStringBuilder AppendLoc(FormattableString value);

  public LocStringBuilder AppendNL(FormattableString value);

  public LocStringBuilder AppendNLStr(string value);

  public LocStringBuilder AppendLocStr(string value);

  public LocStringBuilder AppendLineLoc(FormattableString value);

  public LocStringBuilder AppendLineNL(FormattableString value);

  public LocStringBuilder AppendLineNLStr(string value);

  public LocStringBuilder AppendLineLocStr(string value);

  public LocStringBuilder AppendDashLineLocStr(string value);

  public LocStringBuilder AppendDashLineLoc(FormattableString value);

  /// <summary> Trims format string. </summary>
  public LocStringBuilder TrimFormat();

  /// <summary>Produces <see cref="T:Eco.Shared.Localization.LocString" /> from appended content.</summary>
  public LocString ToLocString();

  public override string ToString();

  public void Clear();
}
