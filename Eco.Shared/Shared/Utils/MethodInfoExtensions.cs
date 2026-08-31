// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.MethodInfoExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Reflection;

#nullable disable
namespace Eco.Shared.Utils;

public static class MethodInfoExtensions
{
  /// <summary>
  /// This will make it so that we always get the right method name.
  /// Why not just use method.Name ? because in some rare cases like when you're overriding an interface method that was already implemented on the original interface the name becomes the full path instead.
  /// </summary>
  public static string GetUnqualifiedMethodName(this MethodInfo method);

  /// <summary>Check whether this method is overriding an interface method that was already implemented on the interface itself by default.</summary>
  public static bool IsAnOverridenInterfaceMethod(this MethodInfo method);
}
