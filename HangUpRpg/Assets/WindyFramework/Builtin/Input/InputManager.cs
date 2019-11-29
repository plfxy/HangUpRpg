using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WindyFramework.Input
{
    public class InputManager : MonoBehaviour
    {
        private MouseManager mouseManager;

        void Start()
        {
            mouseManager = new MouseManager();    
        }

        void Update()
        {
            mouseManager.Update();
        }
    }
}

