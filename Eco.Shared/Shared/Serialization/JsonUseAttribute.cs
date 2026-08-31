// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.JsonUseAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Serialization;

/// <summary>
/// Overrides default strategy for ExpandableObjectContractResolver, it will use this attribute even if read-only and serializeReadOnlyProperties == false.
/// </summary>
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class JsonUseAttribute : Attribute
{
}
