using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WindyFramework.Player
{
    public class PlayerAttribute
    {
        public int Strength
        {
            get
            {
                return _Strength;
            }
            private set
            {
                if (_Strength != value)
                {
                    _Strength = value;
                }
            }
        }
        private int _Strength;

    }
}
