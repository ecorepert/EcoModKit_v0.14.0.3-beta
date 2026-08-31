// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.PlowField
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Construction")]
[LocDescription("Ground was plowed.")]
[ChangeParentConfigLoc("ToolUsed", null, "Plow", null, false)]
[ChangeParentConfigLoc("ItemUsed", null, null, typeof (BlockItem), true)]
public class PlowField : BlockAddRemove
{
}
