// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.IRegistrarManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;

#nullable disable
namespace Eco.Gameplay.Systems;

/// <summary>
/// Provides features for untyped registrar management:
/// - Maintains a set of 'special' entries that are always there.
/// You should prefer to use parameterized types interface instead for implementation, but this interface may be used for type-unaware processing.
/// </summary>
public interface IRegistrarManager
{
  IRegistrar Registrar { get; }

  void InitSpecialEntries();
}
