// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.ThreadSafeAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Serialization;

/// <summary>
/// When serializing some types, such as enumerables, the enumeration must not change - to enforce this, some designate "threadsafe" objects use this attribute, such as the immutable collections.
/// When using this attribute manually, proper locking and other checks must be used the ensure thread safety - in general, use the ThreadSafe collections, but if you are SURE that your container
/// is thread safe, go ahead and add this attribute.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Interface, AllowMultiple = false, Inherited = true)]
public class ThreadSafeAttribute : Attribute
{
}
