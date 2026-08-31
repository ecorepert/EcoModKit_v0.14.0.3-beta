// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.ModuleContext
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Modules;
using Eco.Gameplay.Players;
using System.Numerics;

#nullable enable
namespace Eco.Gameplay.DynamicValues;

/// <summary> Dynamic Value Context for Module (like resource efficiency or speed efficiency). Can be used to calculate <see cref="T:Eco.Gameplay.DynamicValues.IDynamicValue" />. </summary>
public class ModuleContext : IDynamicValueContext
{
  public User User { get; }

  public Vector3 Position { get; }

  public IModule? Module { get; }

  public ModuleContext(User user, Vector3 position, PluginModule? module);
}
