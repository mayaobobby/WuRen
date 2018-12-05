using UnityEngine;
using System.Collections;

namespace SA.GameElements
{
    [CreateAssetMenu(menuName = "Game Elements/My Hand Card")]
    public class HandCard : GE_Logic
    {
        public override void OnClick(CardInstance instance)
        {
            Debug.Log("This card is on my hand");
        }


        public override void OnHighlight(CardInstance instance)
        {

        }
    }
}

