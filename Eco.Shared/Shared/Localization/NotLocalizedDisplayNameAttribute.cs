// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.NotLocalizedDisplayNameAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Shared.Localization;

/// <summary>
/// The standard DisplayNameAttribute doesn't support Enums + other types, so this is a useful extension.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event)]
public class NotLocalizedDisplayNameAttribute : DisplayNameAttribute
{
  public NotLocalizedDisplayNameAttribute(string displayName);
}
