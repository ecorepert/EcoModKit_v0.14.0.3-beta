// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.Auth.ExtraRPCAuthAttribute
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Items;
using System;

#nullable enable
namespace Eco.Shared.Networking.Auth;

public abstract class ExtraRPCAuthAttribute : Attribute
{
  public abstract bool IsAuthorized(
    object target,
    IWorldObserver observer,
    AccessType requiredAccess,
    object[] args);
}
