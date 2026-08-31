// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.IClientControlledList
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Networking;
using System.Collections;

#nullable disable
namespace Eco.Core.Utils;

public interface IClientControlledList : 
  IClientControlledContainer,
  ITrackedControllerEnumerable,
  ITrackedEnumerable,
  IEnumerable
{
  void Move(INetObject caller, int iEntry, int newIndex);

  void SetAt(INetObject caller, int iEntry, object obj);

  void RemoveAt(INetObject caller, int iEntry);

  object GetAt(int iEntry);

  int IndexOf(object obj);
}
