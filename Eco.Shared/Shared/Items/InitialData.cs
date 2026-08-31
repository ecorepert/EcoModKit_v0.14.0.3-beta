// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.InitialData
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Gameplay;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Items;

/// <summary>Container for various data types that can be retrieved from the client on user login, managed by CachedPlayerDataUtil.cs on client</summary>
[Serialized]
public struct InitialData
{
  public bool SkippedTutorials;
  public List<string> CompletedTutorials;
  public List<TutorialTaskPopup> ViewedPopups;
  public List<string> CachedData;
  public AvatarCustomizationData AvatarData;
}
