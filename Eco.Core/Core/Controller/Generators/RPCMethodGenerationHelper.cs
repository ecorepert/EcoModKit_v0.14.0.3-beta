// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.Generators.RPCMethodGenerationHelper
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Networking;

#nullable disable
namespace Eco.Core.Controller.Generators;

/// <summary><see cref="T:Eco.Shared.Networking.RPCMethod" /> generation helper for return type string and method signature.</summary>
public static class RPCMethodGenerationHelper
{
  /// <summary>Generates return type string for <paramref name="rpc" />.</summary>
  internal static string GenerateReturnType(
    this RPCMethod rpc,
    ControllerMarshalerService marshalerService);

  /// <summary>Generates method signature for <paramref name="rpc" />.</summary>
  internal static string GenerateMethodSignature(
    this RPCMethod rpc,
    ControllerMarshalerService marshalerService);
}
