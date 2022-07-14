using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Altom.AltUnityDriver;
using NUnit.Framework;
public class Components
{
    public Components()
    {
    }

    //bu methods her hansi bir objecting component adlarini verir bize
    public List<string> getComponentNamesOfAltUnityObject(AltUnityObject altUnityObject)
    {
        List<string> componentNames = new List<string>();
        for(int i=0; i < altUnityObject.GetAllComponents().Count;i++ )
        {
           // componentNames[i] = altUnityObject.GetAllComponents()[i].componentName;
            componentNames.Add(altUnityObject.GetAllComponents()[i].componentName);
        }
        return componentNames;
    }
    public List<string> getPropertyNamesOfComponent(AltUnityObject altUnityObject, AltUnityComponent altUnityComponent)
    {
        List<string> componentPropertyNames = new List<string>();

        for (int i = 0; i < altUnityObject.GetAllProperties(altUnityComponent).Count; i++)
        {
          //  componentPropertyNames[i] = altUnityObject.GetAllProperties(altUnityComponent)[i].name;
            componentPropertyNames.Add(altUnityObject.GetAllProperties(altUnityComponent)[i].name);
        }
        return componentPropertyNames;
    }




}
