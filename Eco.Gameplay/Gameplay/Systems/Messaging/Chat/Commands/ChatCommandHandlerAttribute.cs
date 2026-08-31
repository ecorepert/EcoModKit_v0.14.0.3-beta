// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatCommandHandlerAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Systems.Messaging.Chat.Commands;

/// <summary>Marks a class as chat commands handler. Class with that attribute will be scanned for chat commands with <see cref="T:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatCommandAttribute" /> and <see cref="T:Eco.Gameplay.Systems.Messaging.Chat.Commands.ChatSubCommandAttribute" />.</summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class ChatCommandHandlerAttribute : Attribute
{
}
