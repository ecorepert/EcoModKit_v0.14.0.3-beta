// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.RegistrarFinder
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Systems.TextLinks;

internal class RegistrarFinder : IObjectFinder, IDisposable
{
  public void InitialGet();

  public void Initialize();

  public 
  #nullable disable
  IEnumerable<LinkData> FindObjects(string text);

  public void Dispose();
}
