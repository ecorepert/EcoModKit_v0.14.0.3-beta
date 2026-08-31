// Decompiled with JetBrains decompiler
// Type: Eco.Core.Systems.IHasUniversalID
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;

#nullable disable
namespace Eco.Core.Systems;

/// <summary>For any object that needs to be referenced by the client and/or server.</summary>
public interface IHasUniversalID
{
  [DontClone]
  ref int ControllerID { get; }
}
