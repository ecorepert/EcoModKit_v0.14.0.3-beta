// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Placement.OrphanAssignmentExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Placement;

public static class OrphanAssignmentExtensions
{
  /// <summary>We use this initializer when we want to wait for the player choice before doing anything else.</summary>
  /// <param name="immediateAssignement">We set this to true when we want to initialize the container immediatly instead of waiting for after creation.</param>
  public static 
  #nullable disable
  Task<bool> OrphanAssignmentInitializeAsync(
    this IOrphanAssignment container,
    bool immediateAssignement = false);

  public static void OrphanAssignmentInitialize(
    this IOrphanAssignment container,
    bool immediateAssignement = false);

  /// <summary>During creation, we need to peform the orphan assignment.</summary>
  public static void OrphanAssignmentOnCreate(this IOrphanAssignment container);
}
