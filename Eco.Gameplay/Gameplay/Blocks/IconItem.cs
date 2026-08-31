// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blocks.IconItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Blocks;

/// <summary>Base class for block forms and fills.</summary>
[HasIcon(null)]
[IconGroup("IconItems")]
public abstract class IconItem : IHasIcon, IController, IViewController, IHasUniversalID
{
  public ref int ControllerID { get; }

  [SyncToView(null, true)]
  public abstract string IconName { get; set; }

  public virtual string IconComment { get; }

  [SyncToView(null, true)]
  public virtual string Name { get; }

  [SyncToView(null, true)]
  public virtual LocString DisplayName { get; }

  [SyncToView(null, true)]
  public virtual LocString DisplayDescription { get; }

  /// <summary> A number used for sorting in lists in the UI. </summary>
  [SyncToView(null, true)]
  public virtual int SortOrder { get; set; }

  [SyncToView(null, true)]
  public RequiresSkillAttribute SkillReq { get; set; }
}
