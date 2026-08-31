// Decompiled with JetBrains decompiler
// Type: Eco.Core.Controller.AutoGenClassBuilder
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Shared.Networking;
using Eco.Shared.View;
using System;
using System.Text;

#nullable disable
namespace Eco.Core.Controller;

/// <summary> Helper class for <see cref="T:Eco.Core.Controller.ViewCodeGenerator" /> which responsible for building View class code. </summary>
internal class AutoGenClassBuilder
{
  public string ViewName { get; }

  public string BaseViewName { get; }

  public AutoGenClassBuilder(
    StringBuilder builder,
    IControllerMarshaler marshaler,
    ControllerMarshalerService marshalerService);

  /// <summary> Begins View class generation. </summary>
  public void BeginClass();

  /// <summary> Begins properties section. </summary>
  public void BeginPropertiesSection();

  /// <summary> Begins properties section which generated from methods. </summary>
  public void BeginMethodPropertiesSection();

  /// <summary> Begins RPC section. </summary>
  public void BeginRPCSection();

  /// <summary> Appends code for property. </summary>
  public void AppendProperty(
    Type propertyType,
    string name,
    string setterAccess,
    SyncFlags flags,
    string help);

  /// <summary> Appends code for RPC. </summary>
  public void AppendRPC(RPCMethod rpc);

  /// <summary> Finishes class generation and adds class prolog. </summary>
  public void EndClass();
}
