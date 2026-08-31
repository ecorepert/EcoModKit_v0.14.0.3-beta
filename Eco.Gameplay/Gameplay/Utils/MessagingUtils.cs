// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Utils.MessagingUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Networking;

#nullable disable
namespace Eco.Gameplay.Utils;

public static class MessagingUtils
{
  /// <summary>Message the user with the given message in error format.</summary>
  public static void NotifyError(INetClient client, LocString message);
}
