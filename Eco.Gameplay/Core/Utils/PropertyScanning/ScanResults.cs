// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.PropertyScanning.ScanResults
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Utils.PropertyScanning;

public class ScanResults
{
  public Result Result;
  public List<PropError> Errors;
  public List<string> Notes;

  public void Merge(ScanResults other);
}
