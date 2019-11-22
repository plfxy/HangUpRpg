using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WindyFramework.Player
{
    interface IPlayerAttributeDecorater
    {
        void LoadDecorater(PlayerAttribute playerAttribute);
        void UnloadDecorater(PlayerAttribute plyerAttribute);
    }
}

