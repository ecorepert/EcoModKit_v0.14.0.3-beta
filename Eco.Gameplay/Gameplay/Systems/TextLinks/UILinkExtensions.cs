// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.UILinkExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.TextLinks;

public static class UILinkExtensions
{
  public static LocString UILink(this ILinkable linkable);

  public static LocString ShortUILink(this ILinkable linkable, int length = 13);

  public static LocString UILink<T>(this ILinkableParameterized<T> linkable, T param);

  public static LocString UILink(this ILinkable linkable, LocString content);

  public static LocString UILink(this Type type, LocString content);

  /// <summary>Helper for showing plural if count != 1, and regular otherwise.</summary>
  public static LocString UILinkPlural(this ILinkableParameterized<LinkConfig> linkable, int count = 2);
}
