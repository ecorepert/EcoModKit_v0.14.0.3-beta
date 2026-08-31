// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.BsonManualSerializeAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Serialization;

/// <summary>
/// Mark a class or struct to indicate to BsonSerializeGenerator that it implements IBsonSerialize manually.
/// Mainly used for BSONObject which has a unique implementation.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class BsonManualSerializeAttribute : Attribute
{
}
