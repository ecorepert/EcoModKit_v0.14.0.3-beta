// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.Internal.UserSubTaskPlayerNearby
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Tutorial.Internal;

/// <summary>Completes when another player comes within a specified distance of this user. Auto-completes if no other players are online (single-player scenario).</summary>
public class UserSubTaskPlayerNearby : UserSubTask
{
  public float RequiredDistance;

  protected override void OnInit();

  protected override void OnDeInit();
}
