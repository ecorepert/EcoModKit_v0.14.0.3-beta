// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ChatTable
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>Builds a column-aligned table for surfaces that render one text field, like chat, where the rich text table markup is shown verbatim instead of laid out.</summary>
/// <remarks>Columns are placed with em tab stops rather than padded with spaces, so they hold with proportional fonts, item icons and translated text of any length.
/// Stops are auto-fitted to the widest cell of each column; pass explicit stops only when a fixed layout is wanted (e.g. lining up several tables).</remarks>
public class ChatTable
{
  /// <summary>A subtle light tint, enough to separate rows without reading as a highlight.</summary>
  public const string SubtleStripe = "#ffffff08";

  public ChatTable(params int[] columnStops);

  /// <summary>Optional column boundaries in em from the start of the line, one per column, the last being the right edge. Omit to auto-fit each column to its widest cell.</summary>
  public ChatTable(ChatTableStyle style, params int[] columnStops);

  /// <summary>Line height applied to the whole table. The frame glyphs come from a fallback font with taller metrics, which would otherwise stretch every row's line box apart.</summary>
  public int LineHeightPercent { get; set; }

  /// <summary>Background tint on every other row, to carry the eye across columns without spending a line on a rule. Off unless set, e.g. to <see cref="F:Eco.Shared.Utils.ChatTable.SubtleStripe" />.</summary>
  public string RowStripeColor { get; set; }

  /// <summary>Adds a row, taking one cell per column. Cells are already-localized text.</summary>
  public void AddRow(params LocString[] cells);

  public LocString ToLocString();

  public override string ToString();
}
