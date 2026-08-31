// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.PropertyScanning.IExternalReferencer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;
using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Utils.PropertyScanning;

/// <summary>Defines a type that doesnt needd a full validity scan, but can still store referneces to things and provides a way to update those referenced things.</summary>
public interface IExternalReferencer
{
  /// <summary>Change any references of 'Key' to 'Value' internally.</summary>
  void SwapRefs(Dictionary<IHasID, IHasID> refsToSwap);
}
