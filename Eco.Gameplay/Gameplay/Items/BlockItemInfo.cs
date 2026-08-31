// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.BlockItemInfo
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Block information about block item passed to client.</summary>
public class BlockItemInfo : ItemInfo
{
  [SyncToView(null, true)]
  public ushort[] PlaceBlockIDs { get; set; }

  [SyncToView(null, true)]
  public bool HasForms { get; set; }
}
