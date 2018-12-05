using UnityEngine;
using System.Collections;

namespace SA
{
    public class CardInstance : MonoBehaviour, IClickable
    {
        public SA.GameElements.GE_Logic currentLogic;

        public void OnClick()
        {
            if (currentLogic == null)
                return;
            currentLogic.OnClick(this);
        }

        public void OnHighlight()
        {
            if (currentLogic == null)
                return;
            //Vector3 s = Vector3.one * 2;
            //this.transform.localScale = s;
            Debug.Log(this.gameObject.name);
            currentLogic.OnHighlight(this);
        }
    }
}