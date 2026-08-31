// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.CoreAttributeExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
namespace Eco.Core.Controller;

public static class CoreAttributeExtensions
{
  public static Eco.Shared.View.SyncFlags SyncFlags(this MemberInfo member);

  public static bool IsSyncToView(this MemberInfo member);

  public static bool IsAutoGen(this MemberInfo member);

  public static bool IsSyncToViewOrAutogen(this MemberInfo member);

  /// <summary>See if a given property name on this type will be getting updates from controller system</summary>
  public static bool IsPropSyncToView(this IController controller, string name);

  public static IEnumerable<PropertyInfo> GetSyncToViewProperties(this Type type);
}
