// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.TollItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Gameplay.Items;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Toll")]
[LocDescription("Toggle on any touching wires and electronic objects.")]
[System.ComponentModel.Category("Hidden")]
[NoIcon]
public class TollItem : WorldObjectItem<TollObject>, IHasEnvVars
{
}
