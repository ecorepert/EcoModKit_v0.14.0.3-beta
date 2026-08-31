// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.PropertyScanning.ScanScope
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;
using System.Reflection;

#nullable disable
namespace Eco.Core.Utils.PropertyScanning;

public struct ScanScope
{
  public object Root;
  public object Current;
  public object Parent;
  public PropertyInfo PropertyInfo;
  public string PropertyPath;
  public string PropertyPathDisplay;
  public PropertyInfo ParentPropertyInfo;
  public IEnumerable<IContextValue> AvailableContext;
  public int Index;
  public bool HashEntry;
  public bool IgnoreValidity;

  public ScanScope(
    ScanScope previousScope,
    object obj,
    string concatPath,
    string concatPathDisplay,
    PropertyInfo prop,
    int index = -1,
    IEnumerable<IContextValue> additionalContext = null);

  public bool HasAttribute<T>() where T : Attribute;

  public void SetValue(object val);

  public ScanScope WithoutContext();

  public ScanScope ScopeOfIndex(int index);

  public ScanScope ScopeOfHashEntry(object entry);

  public bool IsNull();
}
