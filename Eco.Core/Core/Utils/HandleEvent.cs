// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.HandleEvent
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;

#nullable disable
namespace Eco.Core.Utils;

/// <summary> An event that can have callbacks removed via a passed handle. </summary>
public class HandleEvent
{
  public void AddUnique(object handle, Action a);

  public void Add(object handle, Action a);

  public void Remove(object handle);

  public void Invoke();
}
