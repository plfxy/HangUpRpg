using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WindyFramework.Player
{
    public class PlayerAttribute
    {
        public virtual int Strength
        {
            get
            {
                return _Strength;
            }
            protected set
            {
                if (_Strength != value)
                {
                    _Strength = value;
                }
            }
        }
        private int _Strength;

        public int StrengthBase
        {
            get
            {
                return _StrengthBase;
            }
            set {
                _StrengthBase = value;
                Strength = StrengthBase;
            }
        }
        private int _StrengthBase;

        public PlayerAttribute()
        {
            Strength = 0;
        }
    }
}
