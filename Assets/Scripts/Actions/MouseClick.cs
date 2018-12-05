using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.EventSystems;

namespace SA.GameStates
{
    [CreateAssetMenu(menuName = "Actions/MouseClick")]
    public class MouseClick : Action
    {
        public override void Execute(float d)
        {
            if (Input.GetMouseButton(0))
            {
                PointerEventData pointerData = new PointerEventData(EventSystem.current)
                {
                    position = Input.mousePosition
                };

                List<RaycastResult> results = new List<RaycastResult>();

                EventSystem.current.RaycastAll(pointerData, results);

                IClickable c = null;

                foreach (RaycastResult r in results)
                {
                    c = r.gameObject.GetComponentInParent<IClickable>();
                    if (c != null)
                    {
                        c.OnHighlight();
                        break;
                    }
                    else
                    {
                        Debug.Log(r.gameObject.name);
                    }
                }
            }
        }
    }
}