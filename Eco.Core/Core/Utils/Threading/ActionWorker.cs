// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Threading.ActionWorker
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Threading;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Core.Utils.Threading;

/// <summary> Wraps asynchronous action to <see cref="T:Eco.Core.Utils.Threading.IWorker" /> interface. </summary>
public class ActionWorker : WorkerBase
{
  public ActionWorker(Func<CancellationToken, Task> asyncFunc);

  /// <inheritdoc cref="M:Eco.Core.Utils.Threading.WorkerBase.DoWork(System.Threading.CancellationToken)" />
  protected sealed override Task DoWork(CancellationToken token);
}
