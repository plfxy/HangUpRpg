using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace WindyFramework.Event
{
    public class LeftClickEventArgs : EventArgs
    {
        public Transform ClickedObject
        {
            get;
            set;
        }

        public LeftClickEventArgs(Transform transform) : base()
        {
            ClickedObject = transform;
        }
    }
}

