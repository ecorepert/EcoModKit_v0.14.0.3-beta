// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Reputation.ReputationPlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Gameplay.Economy.Reputation.Internal;
using Eco.Shared.Localization;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Economy.Reputation;

[LocDisplayName("ReputationPlugin")]
[Worker(ThreadPriority = ThreadPriority.BelowNormal, Repeatable = true)]
public class ReputationPlugin : 
  SimplePlugin<ReputationManager>,
  IWorkerPlugin,
  IServerPlugin,
  IConfigurablePlugin,
  IEditablePlugin,
  IGUIPlugin,
  IInitializablePlugin
{
  public static Initializer Initializer;

  void IInitializablePlugin.Initialize(TimedTask timer);

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public Task DoWork(CancellationToken token);

  public override string ToString();

  public IPluginConfig PluginConfig { get; }

  public ReputationConfig Config { get; }

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);
}
