// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Icons.IHasRequiredIcons
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Icons;

/// <summary>Use this interface if your class has any icons which are not exist as separate objects.
/// E.g. achievements are stored in manager but we still need to make icons for them, so we tell that we want icons for all achievement through AchievementManager by adding this interface.
/// After that we can create a list of icons we want to have from this class and also you can provide a nice category name with IconsCategoryName (that will make life easier for the Art Team as Icon scene will have this category name).</summary>
public interface IHasRequiredIcons
{
  static string IconsCategoryName;

  static IEnumerable<(string Name, string Comment)> GetRequiredIcons();
}
