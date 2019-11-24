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
                StrengthRefresh();
            }
        }
        private int _StrengthBase;

        public float StrengthModifier
        {
            get
            {
                return _strengthModifier;
            }
            set
            {
                _strengthModifier = value;
                StrengthRefresh();
            }
        }
        private float _strengthModifier;

        public PlayerAttribute()
        {
            StrengthBase = 0;
            StrengthModifier = 0;
        }

        private void StrengthRefresh()
        {
            Strength = (int) (StrengthBase * StrengthModifier);
        }

    }
}
