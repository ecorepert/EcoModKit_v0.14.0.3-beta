// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.Recipes.RequiresModuleAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.Items.Recipes;

[ConstantView]
public class RequiresModuleAttribute : Attribute, IController, IViewController, IHasUniversalID
{
  public static AttributeCache<RequiresModuleAttribute> Cache { get; }

  public Type ModuleType { get; }

  [SyncToView(null, true)]
  public string ModuleName { get; }

  [SyncToView(null, true)]
  public string ModuleLink { get; }

  [SyncToView(null, true)]
  public LocString Description();

  public ref int ControllerID { get; }

  public RequiresModuleAttribute(Type moduleType);

  public RequiresModuleAttribute();
}
