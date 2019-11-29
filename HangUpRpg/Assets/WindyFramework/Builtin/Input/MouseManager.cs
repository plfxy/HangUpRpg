using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindyFramework.Event;

namespace WindyFramework.Input
{
    public class MouseManager 
    {
        private Transform leftClickObject;
        private EventManager eventManager
        {
            get
            {
                if (_eventManager == null)
                {
                    _eventManager = FrameworkEntry.GetComponent<EventManager>();
                }
                return _eventManager;
            }
        }
        private EventManager _eventManager;

        public void Update()
        {
            RaycastHit mousePointedObject;
            mousePointedObject = GetMousePointedObject();

            if (UnityEngine.Input.GetMouseButtonDown(0))
            {    
                leftClickObject = mousePointedObject.transform;
            }

            if (UnityEngine.Input.GetMouseButtonUp(0))
            {
                if (leftClickObject == mousePointedObject.transform)
                {
                    eventManager.Fire(EventsId.MOUSE_LEFT_BUTTON_CLICKED, this, new LeftClickEventArgs(leftClickObject));
                }
            }
        }

        private RaycastHit GetMousePointedObject()
        {
            Ray ray = Camera.main.ScreenPointToRay(UnityEngine.Input.mousePosition);
            RaycastHit hitInfo;
            Physics.Raycast(ray, out hitInfo);
            return hitInfo;
        }
    }
}

