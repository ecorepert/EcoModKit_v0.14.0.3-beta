// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.ForceAotHint
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Networking;

/// <summary>Used to force add a specific class/struct to AoTHints in ViewAutogen on the client, see AutoGenViews.cs for more details.</summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class ForceAotHint : Attribute
{
}
