// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.TooltipPartRef
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Networking;
using System;

#nullable disable
namespace Eco.Shared.Items;

[ForceAotHint]
public struct TooltipPartRef
{
  public static Func<TooltipPartRef, string> MakeDebug;
  public int TooltipPartControllerID;
  public int TargetID;
  public int UserID;

  public override string ToString();

  public TooltipPartRef(int partControllerID, int targetID, int userID);
}
