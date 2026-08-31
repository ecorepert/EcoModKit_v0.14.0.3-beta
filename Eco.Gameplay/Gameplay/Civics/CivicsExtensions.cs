// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.CivicsExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics.Elections;
using System.Reflection;

#nullable disable
namespace Eco.Gameplay.Civics;

public static class CivicsExtensions
{
  /// <summary> Values of the provided election process will be replaced with defaults from the config. </summary>
  public static void SetDefaults(this ElectionProcess election);

  /// <summary> Looks for a property with the same name and replaces its value with the one from the config. </summary>
  public static void TrySetValueFromConfig(
    this ElectionProcess election,
    PropertyInfo configProperty);

  public static bool IsBrowserVisible(this Election election);
}
