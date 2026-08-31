// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.TagDefinition
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary> Tag definition which contains additional attributes for tag. May be used by Mods to configure tags for displaying in different sections or filters. </summary>
public class TagDefinition
{
  /// <summary> Contains mapping for all tag definitions. Where <c>key</c> is the lowercase tag name and <c>value</c> is <see cref="T:Eco.Gameplay.Items.TagDefinition" /> itself. </summary>
  public static Dictionary<string, TagDefinition> All { get; }

  /// <summary> Tag name. </summary>
  public string Name { get; }

  /// <sumary> An optional plural name for tags. </sumary>
  public LocString PluralName { get; set; }

  /// <summary> If the tag should be should in filters. </summary>
  public bool ShowInFilter { get; set; }

  /// <summary> If the tag should be shown as a selectable entry in store item/tag selectors. </summary>
  public bool ShowInStore { get; set; }

  /// <summary> If the tag should be auto highlighted (i.e. in chat). </summary>
  public bool AutoHighlight { get; set; }

  /// <summary> If the tag should be shown in Ecopedia. </summary>
  public bool ShowInEcopedia { get; set; }

  public bool Hidden { get; set; }

  public TagDefinition(string name);

  /// <summary> Registers new <see cref="T:Eco.Gameplay.Items.TagDefinition" />. </summary>
  public static void Register(TagDefinition tagDefinition);
}
