// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.DefaultUserMarkUpService
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable enable
namespace Eco.Gameplay.Players;

/// <summary>Default implementation of <see cref="T:Eco.Gameplay.Players.IUserMarkUpService" /> with user name marked up just as UI link.</summary>
public class DefaultUserMarkUpService : IUserMarkUpService
{
  public LocString MarkUpName(User user);
}
