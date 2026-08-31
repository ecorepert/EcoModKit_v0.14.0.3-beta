// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.Interfaces.IWorkerPlugin
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Core.Plugins.Interfaces;

public interface IWorkerPlugin : IServerPlugin
{
  /// <summary>
  /// Performs one unit of work. There no delay between <see cref="M:Eco.Core.Plugins.Interfaces.IWorkerPlugin.DoWork(System.Threading.CancellationToken)" /> calls, it works pretty much like one iteration of loop.
  /// Usually you need to maintain delay between calls with <see cref="M:System.Threading.Tasks.Task.Delay(System.Int32)" /> or <see cref="M:Eco.Core.Utils.Async.SingleObjectWaiter.WaitAsync(System.Threading.WaitHandle,System.Int64,System.Threading.CancellationToken)" /> or other async wait methods to only perform work as often as required.
  /// Try to avoid idle loops and do work only when required. In some cases it may be preferred to use <see cref="T:Eco.Core.Utils.Threading.PeriodicWorkerFactory" /> instead for more flexible worker creation.
  /// Work may be interrupted between <see cref="M:Eco.Core.Plugins.Interfaces.IWorkerPlugin.DoWork(System.Threading.CancellationToken)" /> calls or provided <paramref name="token" /> can be used to check if work should be cancelled within <see cref="M:Eco.Core.Plugins.Interfaces.IWorkerPlugin.DoWork(System.Threading.CancellationToken)" />.
  /// </summary>
  /// <param name="token">cancellation token.</param>
  Task DoWork(CancellationToken token);
}
