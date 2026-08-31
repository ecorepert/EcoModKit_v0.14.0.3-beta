// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserRecommendationHandler
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Players;

/// <summary>Responsible for mailing recommendations to the user, listens to different events and based on it mails the owning user certain actions that can boost gameplay.</summary>
[Serialized]
public class UserRecommendationHandler
{
  public const string RecommendationMessageIdPrefix = "rec";

  /// <summary>Initializes the recommendation handler to the owning user.</summary>
  public void Initialize(User user);
}
