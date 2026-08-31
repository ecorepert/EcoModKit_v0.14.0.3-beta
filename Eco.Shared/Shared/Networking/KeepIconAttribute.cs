// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.KeepIconAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Networking;

/// <summary>
/// Keep class icon when using as property for GameValue instead of context icon.
/// <para>Example: GameAction contains Citizen property and uses context icon, this attribute will force any User property to use it's own icon.</para>
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class KeepIconAttribute : Attribute
{
}
