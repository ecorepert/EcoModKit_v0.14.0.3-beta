// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.TooltipPartServerRequest
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Items;

/// <summary>Represents a request for a single tooltip part's content.</summary>
public struct TooltipPartServerRequest
{
  public int TooltipPartControllerID;
  public int TypeID;
  public int TargetControllerID;
  public static Func<TooltipPartServerRequest, string> DebugDisplayForRequest;

  public override string ToString();

  public bool IsStaticTooltip { get; }
}
