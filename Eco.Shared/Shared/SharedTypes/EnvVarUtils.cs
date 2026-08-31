// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.EnvVarUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.SharedTypes;

public static class EnvVarUtils
{
  /// <summary>Returns true if cached params are all the same.</summary>
  public static bool CompareEnvVarLists(List<EnvVar> left, List<EnvVar> right);
}
