// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.PlayerV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using Eco.Gameplay.Players;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

public class PlayerV1 : EntityV1
{
  public string Name { get; }

  public PlayerV1(Player player);
}
