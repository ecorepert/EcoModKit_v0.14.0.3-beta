// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.Internal.UserSubTaskPlaceOrOpenWorldObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable enable
namespace Eco.Gameplay.Tutorial.Internal;

/// <summary>Triggers when a world object is placed or its UI is opened. Can also auto-complete if an existing matching object is nearby.</summary>
public class UserSubTaskPlaceOrOpenWorldObject : UserSubTask
{
  public 
  #nullable disable
  string ItemName;
  public bool MustBeInRoom;
  public bool MustBeOnDeed;
  public string RequiredProximityToObject;
  public float RequiredProximityDistance;
  public string MustBeAttachedTo;
  public bool AutoCompleteOnProximity;
  public float AutoCompleteProximityDistance;

  protected override void OnInit();

  protected override void OnDeInit();
}
