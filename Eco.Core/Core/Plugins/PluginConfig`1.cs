// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.PluginConfig`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Plugins;

public class PluginConfig<T> : IPluginConfig where T : new()
{
  public 
  #nullable disable
  string Name { get; }

  public T Config { get; }

  public Dictionary<string, IPluginConfigProperty> ConfigProperties { get; }

  public PluginConfig(string name, bool preserveReferences = false, bool buildConfigProperties = true);

  public PluginConfig(T config);

  public object GetConfig();

  /// <summary> Saves config file asynchronously. Safe for Wait() from UI thread. </summary>
  public Task SaveAsync();

  /// <summary> Saves config file asynchronously to specific filename. Safe for Wait() from UI thread. </summary>
  public Task SaveAsAsync(string filename);

  public Task SaveTemplateAsync();

  public Task LoadAsync(string filename);

  /// <summary> Resets config to default. </summary>
  public Task ResetAsync();

  public string ConfigJson { get; set; }

  public void BuildConfigProperties();
}
