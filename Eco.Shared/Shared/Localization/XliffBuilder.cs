// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.XliffBuilder
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Xml.Linq;

#nullable disable
namespace Eco.Shared.Localization;

/// <summary>
/// Constructs XLIFF 1.2 documents and trans-units in the shape this codebase uses across every loc surface
/// (main game loc, Ecopedia, Web Client). Companion to <see cref="T:Eco.Shared.Localization.XliffFormatter" />: Builder produces the
/// XLinq tree, Formatter serialises it to bytes that match translate-toolkit's (Weblate's) conventions.
/// </summary>
public static class XliffBuilder
{
  public static readonly XNamespace Ns;
  public static readonly XNamespace XmlNs;
  /// <summary>Marker text on a &lt;note from="developer"&gt; that flags a trans-unit as obsolete.
  /// Replaces the pre-Weblate &lt;target state="obsolete"&gt; convention, which Weblate doesn't recognise.</summary>
  public const string ObsoleteNoteText = "Obsolete string";

  /// <summary>Standard XLIFF 1.2 document scaffold around a body element. <paramref name="original" /> is the
  /// &lt;file original="..."&gt; attribute used to identify the surface ("defaultstrings", "EcopediaStrings",
  /// "WebClientStrings").</summary>
  public static XDocument BuildDocument(
    string sourceLang,
    string targetLang,
    string original,
    XElement body);

  /// <summary>The only correct way to navigate to the body of an XLIFF document we author.</summary>
  public static XElement GetBody(XDocument doc);

  /// <summary>
  /// Trans-unit with a text id — main-loc convention where id = the English text verbatim.
  /// &lt;source&gt; and &lt;target&gt; both go through <see cref="M:Eco.Shared.Localization.XliffBuilder.BuildTextElement(System.Xml.Linq.XName,System.String,System.Boolean)" /> with placeholder
  /// wrapping enabled by default. Optional developer note is appended as &lt;note from="developer"&gt;.
  /// </summary>
  public static XElement BuildTransUnit(
    string id,
    string source,
    string target,
    string developerNote = null,
    bool wrapPlaceholders = true);

  /// <summary>
  /// Trans-unit with an integer id — Ecopedia / WebClient convention. Source/target are plain text with
  /// xml:space="preserve"; no placeholder wrapping (those surfaces don't use {N} syntax).
  /// When <paramref name="markNeedsTranslation" /> is true, sets state="needs-translation" on &lt;target&gt;
  /// instead of writing the target text — used when bootstrapping skeletons or untranslated entries.
  /// </summary>
  public static XElement BuildTransUnit(
    int id,
    string source,
    string target,
    bool markNeedsTranslation = false);

  /// <summary>
  /// Builds a &lt;source&gt; or &lt;target&gt; element with xml:space="preserve". When
  /// <paramref name="wrapPlaceholders" /> is true, {N} substrings are wrapped as &lt;ph id="N"&gt;{N}&lt;/ph&gt;
  /// (main-loc strings only); otherwise the text becomes the element's verbatim value.
  /// xml:space="preserve" is critical: without it, the serialiser injects indentation inside the element
  /// (e.g. between adjacent &lt;ph&gt; children), corrupting round-trip text content.
  /// </summary>
  public static XElement BuildTextElement(XName name, string text, bool wrapPlaceholders = false);

  /// <summary>
  /// Rewrites <paramref name="elem" />'s child content with <paramref name="text" />, applying the same
  /// placeholder-wrap rules as <see cref="M:Eco.Shared.Localization.XliffBuilder.BuildTextElement(System.Xml.Linq.XName,System.String,System.Boolean)" />. Preserves the element's attributes
  /// (xml:space, state, etc.) — only the inner content changes. Use when an existing &lt;source&gt; or
  /// &lt;target&gt; element needs new text without losing its place in the tree or its attributes.
  /// </summary>
  public static void SetTextContent(XElement elem, string text, bool wrapPlaceholders = false);

  /// <summary>True if <paramref name="unit" /> carries the obsolete marker
  /// (&lt;note from="developer"&gt;Obsolete string&lt;/note&gt;).</summary>
  public static bool IsObsolete(XElement unit);

  /// <summary>Marks <paramref name="unit" /> obsolete: adds the obsolete developer note and sets
  /// translate="no" so Weblate skips the entry. Target content (existing translation) is preserved
  /// — we don't want to waste translator work in case the entry comes back. Idempotent.</summary>
  public static void MarkObsolete(XElement unit);

  /// <summary>Removes the obsolete marker from <paramref name="unit" />. Also removes translate="no"
  /// UNLESS another non-obsolete reason for it exists (any "Chat command"-family developer note that
  /// isn't a "Help text for chat command" entry). Idempotent.</summary>
  public static void UnObsolete(XElement unit);
}
