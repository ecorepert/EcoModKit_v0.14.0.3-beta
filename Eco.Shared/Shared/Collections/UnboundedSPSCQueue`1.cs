// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.UnboundedSPSCQueue`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Collections;

/// <summary>Unbounded Single Producer Single Consumer Queue.</summary>
/// <remarks>
/// It is safe to use in multi-threaded environment as long as only one thread is consuming and only one thead is producing.
/// It may lead to unpredictable results otherwise.
/// </remarks>
public class UnboundedSPSCQueue<T>
{
  public void Enqueue(T item);

  public bool TryDequeue(out T item);

  public void Clear();
}
