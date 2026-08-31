// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Networking.RPCMethodFlags
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Networking;

/// <summary>Important flags for <see cref="T:Eco.Shared.Networking.RPCMethod" />.</summary>
[Flags]
public enum RPCMethodFlags
{
  None = 0,
  Extension = 1,
  CanAutoPrependClient = 2,
  CanAutoPrependObserver = 4,
  CanAutoPrependConvertedObserver = 8,
  CustomSetter = 16, // 0x00000010
}
