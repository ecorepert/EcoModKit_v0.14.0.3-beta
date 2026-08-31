// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.DigOrMine
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Construction")]
[LocDescription("A block was dug or mined from the ground.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
[ChangeParentConfigLoc("ToolUsed", null, "Excavation", null, false)]
[ChangeParentConfigLoc("ItemUsed", null, "Excavatable", null, false)]
public class DigOrMine : BlockAddRemove
{
}
