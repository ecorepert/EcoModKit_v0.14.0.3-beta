// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.TextLinkManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Gameplay.Systems.TextLinks;

public class TextLinkManager
{
  public static void Initialize();

  public static 
  #nullable disable
  object GetLinkTarget(string linkId);

  public static string GetLinkId(object link);

  public static void OnLinkClicked(
    string linkId,
    TooltipOrigin origin,
    TooltipClickContext clickContext,
    User user);

  /// <summary>Handles button link presses, invokes the give rpc name onto the controller with the given link ID.</summary>
  public static void OnButtonClicked(
    string linkId,
    string rpcMethodName,
    BSONObject args,
    INetClient playerClient);

  public static void OnLinkClicked(
    Player player,
    IController obj,
    TooltipOrigin origin,
    TooltipClickContext clickContext);

  /// <summary>
  /// Adds tooltip links to the text as appropriate.  This is an expensive operation.
  /// </summary>
  public static string MarkUpText(string text);
}
