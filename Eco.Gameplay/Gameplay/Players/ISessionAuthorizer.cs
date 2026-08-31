// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.ISessionAuthorizer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using StrangeCloud.Service.Client.Contracts;

#nullable disable
namespace Eco.Gameplay.Players;

/// <summary>Interface for implementing custom user authorization rules for incoming player connections</summary>
public interface ISessionAuthorizer
{
  /// <summary>Checks if the <seealso cref="T:StrangeCloud.Service.Client.Contracts.StrangeUser" /> instance is authorized to connect to this server.</summary>
  /// <param name="session"><seealso cref="T:StrangeCloud.Service.Client.Contracts.StrangeUser" /> instance to authorize</param>
  /// <returns><c>true</c> if the session is authorized. Otherwise <c>false</c> to continue processing.</returns>
  bool AuthorizeEntity(StrangeUser session);
}
