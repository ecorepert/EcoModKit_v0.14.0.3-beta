// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.IO.ConsoleSynchronizationContext
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Threading;

#nullable enable
namespace Eco.Core.Utils.IO;

public class ConsoleSynchronizationContext : SynchronizationContext
{
  public static 
  #nullable disable
  ConsoleSynchronizationContext Instance;

  public void Start();

  public void Shutdown();

  public override SynchronizationContext CreateCopy();

  public override void Post(SendOrPostCallback d, object state);

  public override void Send(SendOrPostCallback d, object state);
}
