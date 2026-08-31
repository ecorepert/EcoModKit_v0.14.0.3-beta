// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.GeneratedRegistrar`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Systems;

/// <summary>Implementation of <see cref="T:Eco.Core.Systems.Registrar`1" /> for registrars generated in runtime. Works in pair with <see cref="T:Eco.Core.Systems.GeneratedRegistrarWrapper`1" />.</summary>
public class GeneratedRegistrar<T> : Registrar<T> where T : class, IHasID
{
  public void PreInit(
    LocString registrarName,
    bool shareWithClient,
    ISaveablePlugin? save,
    string? ecopediaPageName = null,
    bool hidden = false);

  /// <summary>Adds mapping between name and object, but doesn't allocate ID. IDs allocated when <see cref="M:Eco.Core.Systems.GeneratedRegistrar`1.PreInit(Eco.Shared.Localization.LocString,System.Boolean,Eco.Core.Plugins.Interfaces.ISaveablePlugin,System.String,System.Boolean)" /> called. May be only used before registrar initialized.</summary>
  public T AddNameMapping(string name, T obj);

  /// <summary>Claims IDs by name for all matching objects in registrar.</summary>
  internal void ClaimIDs(Dictionary<string, int> ids);
}
