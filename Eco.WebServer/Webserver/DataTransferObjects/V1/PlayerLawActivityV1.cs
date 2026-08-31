// Decompiled with JetBrains decompiler
// Type: Eco.WebServer.DataTransferObjects.V1.PlayerLawActivityV1
// Assembly: Eco.WebServer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 928A4994-7F56-454E-B344-AF537A2B649B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WebServer.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.WebServer.DataTransferObjects.V1;

public class PlayerLawActivityV1
{
  public ActivityItemV1 LawsProposed { get; }

  public ActivityItemV1 LawsVotedOn { get; }

  public ActivityItemV1 LawCommentsSent { get; }

  public string Summary { get; }

  public PlayerLawActivityV1(
    string username,
    List<Guid> lawsProposed,
    List<Guid> lawsVotedOn,
    int lawCommentsSent,
    List<Guid> lawsCommentedOn);
}
