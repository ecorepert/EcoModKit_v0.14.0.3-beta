// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.Auth.UnauthenticatedRpcJustificationAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable enable
namespace Eco.Shared.Networking.Auth;

/// <summary>Required companion attribute for any [RPC(AccessType.None)] method. The reason string is surfaced in audit logs and code review.</summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class UnauthenticatedRpcJustificationAttribute : Attribute
{
  public string Reason { get; }

  public UnauthenticatedRpcJustificationAttribute(string reason);
}
