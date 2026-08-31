// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.SimplePluginConfigProperty
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Plugins;

public class SimplePluginConfigProperty : IPluginConfigProperty
{
  public SimplePluginConfigProperty(System.Type type, string kind = "simple");

  public string Name { get; set; }

  public string DisplayName { get; set; }

  public string Description { get; set; }

  public string Category { get; set; }

  public string Type { get; set; }

  public string Kind { get; set; }

  public Dictionary<string, IPluginConfigProperty> Properties { get; set; }

  public string Editor { get; set; }
}
