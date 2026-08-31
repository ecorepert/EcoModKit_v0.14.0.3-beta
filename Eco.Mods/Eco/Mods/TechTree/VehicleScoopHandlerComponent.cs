// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.VehicleScoopHandlerComponent
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Gameplay.Objects;
using Eco.Shared.Serialization;
using System.ComponentModel;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>Handles shared vehicle scoop/bucket tool logic: stump destruction and trunk piece pickup.</summary>
[Category("Hidden")]
[Serialized]
[NoIcon]
public class VehicleScoopHandlerComponent : WorldObjectComponent
{
  public override void Initialize();

  public override void Destroy();
}
