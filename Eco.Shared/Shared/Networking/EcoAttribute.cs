// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.EcoAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Items;
using Eco.Shared.Networking.Auth;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Networking;

/// <summary>
/// One attribute to rule them all. This gives all the bells-and-whistles to a property or class, including:
///  - Serialized.          Loads and saves the entry.
///  - SyncToView.          It creates a view of the property on the client and keeps it updated.
///  - AutoRPC.             Creates an RPC for the client to edit this parameter.
///  - AutoGen.             Tags the member to have UI generated for it automatically created on the client.
///  - Property Scanning.   The Property Scanner will traverse into it to update validity.
///  - PropertyExplanation. Explains the property.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum | AttributeTargets.Method | AttributeTargets.Property)]
public class EcoAttribute : ProfanityAttribute, IRPCAttribute
{
  public SyncFlags Flags;

  public AccessType RequiredAccess { get; set; }

  List<ExtraRPCAuthAttribute> IRPCAttribute.ExtraAuthAttributes { get; set; }

  public EcoAttribute(AccessType requiredAccess);

  public EcoAttribute(bool serialized = true);

  public EcoAttribute(SyncFlags flags);

  public bool Serialized { get; set; }
}
