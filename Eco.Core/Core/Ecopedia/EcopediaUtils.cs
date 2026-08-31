// Decompiled with JetBrains decompiler
// Type: Eco.Core.Ecopedia.EcopediaUtils
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Core.Ecopedia;

/// <summary> Ecopedia utils. </summary>
public static class EcopediaUtils
{
  /// <summary> Returns page name for <paramref name="type" />. If this type is in a subpage, it actually returns the name of the parent page.</summary>
  public static string GetPageName(Type type, EcopediaAttribute attr);

  public static string GetSubPageName(Type type);

  /// <summary> Returns page display name for <paramref name="type" />. </summary>
  public static LocString GetPageDisplayName(Type type, EcopediaAttribute attr);

  public static LocString GetSubPageDisplayName(Type type);
}
