// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ChatTableStyle
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>The glyphs a <see cref="T:Eco.Shared.Utils.ChatTable" /> draws its frame with.</summary>
public readonly struct ChatTableStyle
{
  public readonly char Horizontal;
  public readonly char Vertical;
  public readonly char TopLeft;
  public readonly char TopJoin;
  public readonly char TopRight;
  public readonly char BottomLeft;
  public readonly char BottomJoin;
  public readonly char BottomRight;

  public ChatTableStyle(
    char horizontal,
    char vertical,
    char topLeft,
    char topJoin,
    char topRight,
    char bottomLeft,
    char bottomJoin,
    char bottomRight);

  /// <summary>Box drawing glyphs. Only safe where the font covers them, which varies by language fallback.</summary>
  public static ChatTableStyle Box { get; }

  /// <summary>Plain glyphs, safe in every font.</summary>
  public static ChatTableStyle Ascii { get; }
}
