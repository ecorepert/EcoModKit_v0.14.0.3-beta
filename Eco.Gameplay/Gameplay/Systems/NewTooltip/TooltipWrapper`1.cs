// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipWrapper`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip;

public abstract class TooltipWrapper<T> : IFormattable, IController, IViewController, IHasUniversalID
{
  public T Wrapped { get; }

  public TooltipWrapper(T wrapped);

  public override bool Equals(object obj);

  public override int GetHashCode();

  public override string ToString();

  public string ToString(string format, IFormatProvider formatProvider = null);

  public ref int ControllerID { get; }
}
