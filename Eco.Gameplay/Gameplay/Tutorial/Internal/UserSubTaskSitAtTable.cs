// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.Internal.UserSubTaskSitAtTable
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Tutorial.Internal;

/// <summary>Completes when the user sits in a chair at a table on their owned deed. Optionally checks for food on the table.</summary>
public class UserSubTaskSitAtTable : UserSubTask
{
  public float TableProximity;
  public bool RequireFoodOnTable;
  public bool MustBeOnDeed;

  protected override void OnInit();

  protected override void OnDeInit();
}
