// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.IRegistrarManager`2
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;

#nullable disable
namespace Eco.Gameplay.Systems;

public interface IRegistrarManager<TType, TSpecialType> : IRegistrarManager where TType : class, ISpecialRegistrarEntry, IHasID
{
  TType[] SpecialEntries { get; set; }

  void InitSpecialEntry(TType specialEntry);

  IRegistrar IRegistrarManager.Registrar { get; }

  Eco.Core.Systems.Registrar<TType> Registrar { get; }

  bool ShouldMakeSpecialEntry(TSpecialType type);

  void IRegistrarManager.InitSpecialEntries();
}
