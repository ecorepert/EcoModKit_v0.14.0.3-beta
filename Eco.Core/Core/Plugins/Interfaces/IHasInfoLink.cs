// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.Interfaces.IHasInfoLink
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Core.Plugins.Interfaces;

/// <summary>
/// Implemented by plugins that want a small informational footer with a clickable inline hyperlink rendered below
/// their config PropertyGrid in the WinForms admin UI. Use case: pointing admins at a related resource (e.g.
/// translation portal, wiki page, support channel) without crowding the property descriptions.
/// <para>
/// The footer text uses a format string with a single <c>{0}</c> placeholder that gets substituted with the
/// localized link text at runtime. The form code finds the link text within the formatted message and renders it
/// as a hyperlink that navigates to <see cref="P:Eco.Core.Plugins.Interfaces.IHasInfoLink.InfoUrl" /> when clicked. Both <see cref="P:Eco.Core.Plugins.Interfaces.IHasInfoLink.InfoTextFormat" /> and
/// <see cref="P:Eco.Core.Plugins.Interfaces.IHasInfoLink.InfoLinkText" /> are localized; the URL stays in code and is not extracted for translation.
/// </para>
/// </summary>
public interface IHasInfoLink
{
  /// <summary>Localized format string for the footer message, containing exactly one <c>{0}</c> placeholder where
  /// <see cref="P:Eco.Core.Plugins.Interfaces.IHasInfoLink.InfoLinkText" /> gets substituted at runtime. Translators must preserve the <c>{0}</c>.</summary>
  LocString InfoTextFormat { get; }

  /// <summary>Localized text rendered as a clickable hyperlink inside the footer message.</summary>
  LocString InfoLinkText { get; }

  /// <summary>The URL opened in the default browser when the user clicks the hyperlink.</summary>
  string InfoUrl { get; }
}
