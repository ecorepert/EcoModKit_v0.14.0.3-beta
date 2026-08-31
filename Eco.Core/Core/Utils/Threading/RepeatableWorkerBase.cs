// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Threading.RepeatableWorkerBase
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Utils.Threading;

/// <summary> Base class for workers which implements default repeatable Worker workflow. </summary>
public abstract class RepeatableWorkerBase : WorkerBase
{
  /// <summary> Performs repeatable work, may be cancelled with <paramref name="token" />. </summary>
  protected abstract Task DoRepeatableWork(CancellationToken token);

  /// <summary> Main work loop which repeats <see cref="M:Eco.Core.Utils.Threading.RepeatableWorkerBase.DoRepeatableWork(System.Threading.CancellationToken)" /> until cancelled. </summary>
  protected sealed override Task DoWork(CancellationToken token);
}
