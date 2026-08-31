// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.TimedTask
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Core.Utils;

public sealed class TimedTask : IDisposable
{
  public float LoadPercentage { set; }

  public TimedTask(LocString taskName, bool reportOnSameLine = true);

  public void Dispose();
}
