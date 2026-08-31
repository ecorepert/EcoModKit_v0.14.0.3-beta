// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.IPluginConfigProperty
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Plugins;

public interface IPluginConfigProperty
{
  string Name { get; set; }

  string DisplayName { get; set; }

  string Description { get; set; }

  string Type { get; set; }

  string Kind { get; set; }

  string Category { get; set; }

  Dictionary<string, IPluginConfigProperty> Properties { get; set; }

  string Editor { get; set; }
}
