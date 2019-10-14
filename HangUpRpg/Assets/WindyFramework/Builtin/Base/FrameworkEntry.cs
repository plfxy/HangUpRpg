using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WindyFramework
{
    public static class FrameworkEntry
    {
        private readonly static LinkedList<FrameworkModule> _FrameworkComponents = new LinkedList<FrameworkModule>();

        public static void RegisterComponent(FrameworkModule frameworkComponent)
        {
            if (HasComponent(frameworkComponent.GetType()))
            {
                Debug.LogError("Can't Regist " + frameworkComponent.GetType().FullName + "twice");
            }
            else{
                _FrameworkComponents.AddLast(frameworkComponent);
            }
        }

        public static T GetComponent<T>() where T : FrameworkModule
        {
            return GetComponent(typeof(T)) as T;
        }

        public static FrameworkModule GetComponent(Type frameworkComponentType)
        {
            foreach (FrameworkModule frameworkComponent in _FrameworkComponents)
            {
                if (frameworkComponent.GetType() == frameworkComponentType)
                {
                    return frameworkComponent;
                }
            }
            Debug.LogError("Can't get framework component : " + frameworkComponentType.FullName);
            return null;
        }

        public static bool HasComponent(Type frameworkComponentType)
        {
            foreach (FrameworkModule frameworkComponent in _FrameworkComponents)
            {
                if (frameworkComponent.GetType() == frameworkComponentType)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

