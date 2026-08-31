// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.ItemInfo
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Items;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>General information about item passed to client. Also see inherited classes for additional info.</summary>
[ConstantView]
public class ItemInfo : IController, IViewController, IHasUniversalID
{
  [SyncToView(null, true)]
  public PossibleInteractions InteractionMask { get; set; }

  [SyncToView(null, true)]
  public int TypeID { get; set; }

  [SyncToView(null, true)]
  public int BaseItemID { get; set; }

  [SyncToView(null, true)]
  public bool Hidden { get; set; }

  [SyncToView(null, true)]
  public string GroupName { get; set; }

  [SyncToView(null, true)]
  public int MaxStackSize { get; set; }

  public ref int ControllerID { get; }
}
