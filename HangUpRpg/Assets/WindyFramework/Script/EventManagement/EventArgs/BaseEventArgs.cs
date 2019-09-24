using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameFramework {
    public abstract class BaseEventArgs : GameFrameworkEventArgs
    {
        public abstract int Id { get; }
    }
}

