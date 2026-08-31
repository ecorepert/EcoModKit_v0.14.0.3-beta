// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Modules.IModule
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.DynamicValues;

#nullable disable
namespace Eco.Gameplay.Modules;

/// <summary> Interface for in-game modules. Now it is only used for PluginModule, but going to be extended for all module types. Provides API point for modifying dynamic modules within <see cref="T:Eco.Gameplay.DynamicValues.ModuleContext" />. </summary>
public interface IModule
{
  float Modify(ModuleModifiedValue value);
}
