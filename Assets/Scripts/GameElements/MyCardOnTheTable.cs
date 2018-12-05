using UnityEngine;
using System.Collections;

namespace SA.GameElements
{
    [CreateAssetMenu(menuName = "Game Elements/My Card On The Table")]
    public class MyCardOnTheTable : GE_Logic
    {
        public override void OnClick(CardInstance instance)
        {
            Debug.Log("This card is on the table");
        }


        public override void OnHighlight(CardInstance instance)
        {

        }
    }
}
