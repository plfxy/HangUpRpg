using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WindyFramework.Player
{
    interface IPlayerAttributeDecorater
    {
        PlayerAttribute DecoratePlayerAttribute(PlayerAttribute playerAttribute);
    }
}

