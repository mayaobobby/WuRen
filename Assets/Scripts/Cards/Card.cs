using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SA
{
    [CreateAssetMenu(menuName ="Card")]
    public class Card : ScriptableObject
    {
        /*
        public string cardName;
        public Sprite art;
        public string cardDetail;
        public string cardFlavor;
        public string artist;
        */
        public CardType cardtype; 
        public CardProperties[] properties;
    }
}