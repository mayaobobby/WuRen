using UnityEngine;
using System.Collections;

namespace SA
{
    public class CardInstance : MonoBehaviour, IClickable
    {


        public void OnClick()
        {

        }

        public void OnHighlight()
        {
            Debug.Log(this.gameObject.name);
        }
    }
}