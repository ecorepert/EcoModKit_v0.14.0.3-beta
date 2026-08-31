// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.PlayerElectionActivityV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

public class PlayerElectionActivityV1
{
  public ActivityItemV1 ElectionsJoined { get; }

  public ActivityItemV1 ElectionsVotedOn { get; }

  public ActivityItemV1 ElectionCommentsSent { get; }

  public string Summary { get; }

  public PlayerElectionActivityV1(
    string username,
    List<Guid> electionsJoined,
    List<Guid> electionsVotedOn,
    int electionCommentsSent,
    List<Guid> electionsCommentedOn);
}
