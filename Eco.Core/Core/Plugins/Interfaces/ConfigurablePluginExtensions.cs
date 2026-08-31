// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.Interfaces.ConfigurablePluginExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Core.Plugins.Interfaces;

public static class ConfigurablePluginExtensions
{
  public static void PropChanged(this IConfigurablePlugin plugin, string propertyName);

  public static Task LoadConfigAsync(this IConfigurablePlugin plugin, string filename);

  public static void SaveConfig(this IConfigurablePlugin plugin);

  public static Task SaveConfigAsync(this IConfigurablePlugin plugin);

  public static Task SaveConfigAsAsync(this IConfigurablePlugin plugin, string filename);

  public static void UpdateConfigFromJson(this IConfigurablePlugin plugin, JObject json);
}
