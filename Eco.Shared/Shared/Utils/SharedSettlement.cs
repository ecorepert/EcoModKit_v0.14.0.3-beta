// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.SharedSettlement
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>Holds the reference to SettlementConfig for easy access from anywhere. it's set from SettlementDefinitions</summary>
public static class SharedSettlement
{
  /// <summary>Used on both client and server, so settlement properties are shared through dll.</summary>
  public static void SetSettlementConfig<TConfig>(TConfig config) where TConfig : ISettlementConfig;
}
