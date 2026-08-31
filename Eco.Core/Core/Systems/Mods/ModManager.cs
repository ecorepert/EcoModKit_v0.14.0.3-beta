// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.Mods.ModManager
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Core.Plugins.Interfaces;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Systems.Mods;

/// <summary>Tracks registered mods in the server.</summary>
public class ModManager : IController, IViewController, IHasUniversalID
{
  public void RegisterMods(
  #nullable disable
  IEnumerable<ModRegistration> mods);

  public IEnumerable<ModRegistration> AllMods { get; }

  public ref int ControllerID { get; }
}
