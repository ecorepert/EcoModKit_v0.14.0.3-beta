// Decompiled with JetBrains decompiler
// Type: Eco.Shared.EcoVersionUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared;

public class EcoVersionUtils
{
  public static readonly bool IsDebug;
  public static readonly bool IsDevelop;
  public static readonly bool IsStaging;
  public static readonly bool IsPlaytest;
  public static readonly bool IsRelease;
  public static readonly bool IsProduction;

  /// <summary>Returns the associated git branch for the current version of Eco</summary>
  public static string GetVersionBranch();
}
