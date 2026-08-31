// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.IgnoreValidityAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Networking;

/// <summary> When this is encountered, the Property Scanner will continue scanning that property and any children properties, but will no longer check validity. This is useful when you have a property with members who's validity shouldnt affect our own (like actions that an election references), but you still want to perform the other features PropertyManager provides (like setting up references). </summary>
[AttributeUsage(AttributeTargets.Property)]
public class IgnoreValidityAttribute : Attribute
{
}
