// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.StrangeCloudWorldRegistration
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Shared.Networking;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Plugins.Networking;

/// <summary>Various functions for managing registration of this world with strange cloud, and storing a cache of the cloud data..</summary>
public static class StrangeCloudWorldRegistration
{
  public static 
  #nullable disable
  StrangeWorld StrangeWorld { get; }

  public static string StrangeWorldCloudDataJson { get; }

  public static Task UpdateAndRegisterStrangeWorld();
}
