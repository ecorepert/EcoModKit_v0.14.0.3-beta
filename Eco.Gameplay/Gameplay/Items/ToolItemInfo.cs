// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ToolItemInfo
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Tool related information about tool passed to client.</summary>
public class ToolItemInfo : InteractableItemInfo
{
  [SyncToView(null, true)]
  public int MaxTake { get; set; }

  [SyncToView(null, true)]
  public float Tier { get; set; }
}
