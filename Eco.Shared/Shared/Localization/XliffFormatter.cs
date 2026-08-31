// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.XliffFormatter
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Linq;

#nullable disable
namespace Eco.Shared.Localization;

/// <summary>
/// Serializes XLIFF documents using byte conventions that match translate-toolkit's (Weblate's) output:
/// pretty-printed with 2-space indent, LF line endings, no BOM, and the XML declaration's encoding written
/// as "UTF-8" (uppercase). Without this, every Weblate roundtrip would produce a noisy diff against our
/// generated files even when no content changed.
/// </summary>
public static class XliffFormatter
{
  public static readonly Encoding XliffEncoding;

  /// <summary>Default settings for our XLIFF output. Returns a fresh instance each call so callers may tweak it.</summary>
  public static XmlWriterSettings CreateWriterSettings();

  /// <summary>Saves the document to <paramref name="path" /> using the standard XLIFF byte conventions.</summary>
  public static void Save(XDocument doc, string path);

  /// <summary>Saves the document to <paramref name="stream" /> using the standard XLIFF byte conventions.</summary>
  public static void Save(XDocument doc, Stream stream);

  /// <summary>Serializes the document to a byte array using the standard XLIFF byte conventions. Useful for idempotent-write callers that want to diff against an existing file's bytes before deciding whether to write.</summary>
  public static byte[] ToBytes(XDocument doc);

  private sealed class Utf8NoBomUpperCase : UTF8Encoding
  {
    public override string WebName { get; }
  }
}
