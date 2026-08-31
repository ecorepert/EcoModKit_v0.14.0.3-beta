// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.MemberUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Reflection;

#nullable disable
namespace Eco.Shared.Utils;

public static class MemberUtils
{
  public static Type GetValueType(this MemberInfo memberInfo);

  public static void SetValueToMember(this MemberInfo memberInfo, object parentObj, object value);

  public static object GetMemberValue(this MemberInfo memberInfo, object parentObj);

  /// <summary> Returns true if this member is a field, or a property with a setter. </summary>
  public static bool IsSettable(this MemberInfo memberInfo);
}
