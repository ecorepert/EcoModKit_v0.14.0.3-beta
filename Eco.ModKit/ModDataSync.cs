// Decompiled with JetBrains decompiler
// Type: Eco.ModKit.ModDataSync
// Assembly: Eco.ModKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D0F27988-08B6-4796-AA77-04BE8CC394E1
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.ModKit.xml

using Eco.Shared.Networking;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.ModKit;

public class ModDataSync
{
  public void Initialize();

  public 
  #nullable disable
  BSONObject GetModData(INetClient client);
}
