// Decompiled with JetBrains decompiler
// Type: Eco.Shared.View.IView
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Shared.View;

public interface IView : IViewController, IObservable
{
  string TypeName { get; }

  ViewClassInfo ClassInfo { get; }

  int ViewTypeID { get; set; }

  int ControllerID { get; set; }

  object GetValue(string propName, int index = -1);

  void RPC(string methodname, params object[] args);

  void RPC(string methodname, Action response, params object[] args);

  void RPC<T>(string methodname, Action<T> response, params object[] args);

  void UpdateProperty(BSONValue propNameID, BSONObject bson);
}
