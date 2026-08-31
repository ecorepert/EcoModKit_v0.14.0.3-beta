// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatCommandAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using JetBrains.Annotations;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

[AttributeUsage(AttributeTargets.Method)]
[MeansImplicitUse]
public class ChatCommandAttribute : Attribute
{
  public bool NeedsClient { get; }

  public string Parent { get; protected set; }

  public bool TestFunction { get; protected set; }

  public string HelpText { get; protected set; }

  public string ShortCut { get; protected set; }

  public ChatAuthorizationLevel Level { get; protected set; }

  public ChatCommandAttribute(string helpText = "", ChatAuthorizationLevel level = ChatAuthorizationLevel.User);

  public ChatCommandAttribute(string helpText = "");

  public ChatCommandAttribute(string helpText = "", string shortCut = "", ChatAuthorizationLevel level = ChatAuthorizationLevel.User);

  public ChatCommandAttribute(ChatAuthorizationLevel level = ChatAuthorizationLevel.User);
}
