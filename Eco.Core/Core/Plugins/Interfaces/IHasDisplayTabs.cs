// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.Interfaces.IHasDisplayTabs
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Core.Plugins.Interfaces;

/// <summary>
/// Interface which may be used by plugins which provides generates custom display text.
/// Plugin should return enumerable of <see cref="T:Eco.Core.Plugins.Interfaces.IDisplayTab" /> objects each of which represents a display tab.
/// </summary>
public interface IHasDisplayTabs
{
  IEnumerable<IDisplayTab> DisplayTabs { get; }
}
