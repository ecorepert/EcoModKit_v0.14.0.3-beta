// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.RPCAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Items;
using Eco.Shared.Networking.Auth;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Networking;

/// <summary> Creates an RPC that can be called on the client. See <strong>RPCAuthorization.md</strong> for details.</summary>
[AttributeUsage(AttributeTargets.Method)]
public class RPCAttribute : Attribute, IRPCAttribute
{
  public RPCAttribute();

  public RPCAttribute(AccessType requiredAccess);

  public AccessType RequiredAccess { get; set; }

  List<ExtraRPCAuthAttribute> IRPCAttribute.ExtraAuthAttributes { get; set; }
}
