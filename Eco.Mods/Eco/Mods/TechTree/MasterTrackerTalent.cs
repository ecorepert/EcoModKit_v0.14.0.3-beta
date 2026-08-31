// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.MasterTrackerTalent
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>Server side talent definition for "MasterTracker".</para>
/// <para>More information about Talent objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Skills.Talent.html</para>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
/// </summary>
/// <summary>This talents give user ability to highlight last hit animal using <see cref="T:Eco.Gameplay.Players.ConstantHighlightSetting" />.</summary>
public class MasterTrackerTalent : Talent
{
  public override bool Base { get; }

  public override void RegisterTalent(User user);

  public override void UnRegisterTalent(User user);
}
