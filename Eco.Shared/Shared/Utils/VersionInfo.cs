// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.VersionInfo
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Text.RegularExpressions;

#nullable disable
namespace Eco.Shared.Utils;

public struct VersionInfo : IComparable<VersionInfo>
{
  private static readonly Regex VersionRegex;

  public readonly byte MajorVersion { get; }

  public readonly byte MinorVersion { get; }

  public readonly byte PatchVersion { get; }

  public readonly byte HotfixVersion { get; }

  public VersionInfo(byte majorVersion, byte minorVersion, byte patchVersion, byte hotfixVersion);

  public static bool TryParse(string version, out VersionInfo versionInfo);

  public int CompareTo(VersionInfo other);

  public static bool operator >=(VersionInfo lhs, VersionInfo rhs);

  public static bool operator <=(VersionInfo lhs, VersionInfo rhs);

  public static bool operator >(VersionInfo lhs, VersionInfo rhs);

  public static bool operator <(VersionInfo lhs, VersionInfo rhs);
}
