// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.ClientSideInteractionParameterNames
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.SharedTypes;

/// <summary> These parameters ONLY exist on the client and are NEVER sent to the server. The server can and should still use them though (read below). </summary>
/// <remarks> Any of these keys can be added as a required parameter on the interaction definitions sent by the server, so the client can decide whether an interaction should be displayed or not. </remarks>
public static class ClientSideInteractionParameterNames
{
  public const string TargetingBed = "sleep";
  public const string TargetingSit = "sit";
  public const string ElevatorUp = "Up";
  public const string ElevatorDown = "Down";
  public const string ElevatorStop = "Stop";
}
