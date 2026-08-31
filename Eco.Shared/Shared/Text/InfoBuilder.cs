// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Text.InfoBuilder
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Shared.Text;

public class InfoBuilder
{
  public bool IsEmpty { get; }

  /// <summary>Add a section.</summary>
  public InfoBuilder AddSection(LocString sectionTitle, InfoBuilder? section);

  /// <summary>See <see cref="M:Eco.Shared.Text.InfoBuilder.AddSection(Eco.Shared.Localization.LocString,Eco.Shared.Text.InfoBuilder)" />.</summary>
  public InfoBuilder AddSectionLoc(FormattableString sectionTitle, InfoBuilder? section);

  /// <summary>See <see cref="M:Eco.Shared.Text.InfoBuilder.AddSection(Eco.Shared.Localization.LocString,Eco.Shared.Text.InfoBuilder)" />.</summary>
  public InfoBuilder AddSectionLocStr(string sectionTitle, InfoBuilder? section);

  /// <summary>Adds '- ' to section tittle. See <see cref="M:Eco.Shared.Text.InfoBuilder.AddSection(Eco.Shared.Localization.LocString,Eco.Shared.Text.InfoBuilder)" />.</summary>
  public InfoBuilder AddDashSectionLocStr(string sectionTitle, InfoBuilder? section);

  /// <summary> Appends new line to <see cref="T:Eco.Shared.Text.InfoBuilder" />. </summary>
  public InfoBuilder AppendLine();

  /// <summary> Appends <see cref="T:Eco.Shared.Localization.LocString" /> with new line to <see cref="T:Eco.Shared.Text.InfoBuilder" />. </summary>
  public InfoBuilder AppendLine(LocString line);

  /// <summary>See <see cref="M:Eco.Shared.Text.InfoBuilder.AppendLine(Eco.Shared.Localization.LocString)" />.</summary>
  public InfoBuilder AppendLineLoc(FormattableString line);

  /// <summary>Adds '- ' to line. See <see cref="M:Eco.Shared.Text.InfoBuilder.AppendLine(Eco.Shared.Localization.LocString)" />.</summary>
  public InfoBuilder AppendDashLineLoc(FormattableString line);

  /// <summary>See <see cref="M:Eco.Shared.Text.InfoBuilder.AppendLine(Eco.Shared.Localization.LocString)" />.</summary>
  public InfoBuilder AppendLineLocStr(string line);

  /// <summary> Adds '- ' to line, See <see cref="M:Eco.Shared.Text.InfoBuilder.AppendLine(Eco.Shared.Localization.LocString)" />.</summary>
  public InfoBuilder AppendDashLineLocStr(string line);

  public override string ToString();

  public LocString ToLocString();

  public void Clear();
}
