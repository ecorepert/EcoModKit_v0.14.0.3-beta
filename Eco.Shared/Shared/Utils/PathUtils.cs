// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.PathUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>Home for <see cref="T:System.IO.Path" /> utility functions.</summary>
public class PathUtils
{
  /// <summary>Replaces all invalid file name characters with '_' and removes trailing '.' if exists.</summary>
  public static string SanitizeFileName(string value);

  /// <summary>Checks if a string path is within a root directory.</summary>
  /// <param name="root">Root directory to check for</param>
  /// <param name="path">Path to check.</param>
  /// <returns><c>true</c> if the path value of <paramref name="path" /> is contained within <paramref name="root" />&gt;. Otherwise <c>false</c>.</returns>
  public static bool IsSubPath(string root, string path);
}
