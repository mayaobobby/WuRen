using UnityEngine;
using System.Collections;
using UnityEngine.UI;

namespace SA
{
    public class CardViz: MonoBehaviour
    {
        /*
        public Text title;
        public Text detail;
        public Text flavor;
        public Text artist;
        public Image art;
        */
        public Card card;
        public CardVizProperties[] properties;
        public GameObject statsHolder;
        public GameObject resourceHolder;

        private void Start()
        {
            LoadCard(card);
        }

        public void LoadCard(Card c)
        {
            if (c == null)
                return;

            card = c;
            //c.cardtype.OnSetType(this);

            for (int i = 0; i < c.properties.Length;i++)
            {
                CardProperties cp = c.properties[i];
                CardVizProperties p = GetProperties(cp.element);
                if(p == null)
                {
                    continue; 
                }
                if(cp.element is ElementText)
                {
                    p.text.text = cp.stringValue;
                }
                else if(cp.element is ElementImage)
                {
                    p.img.sprite = cp.sprite;
                }
                else if(cp.element is ElementInt)
                {
                    p.text.text = cp.intValue.ToString();
                }
            }
            /*
            title.text = c.cardName;
            detail.text = c.cardDetail;
            if(string.IsNullOrEmpty(c.cardFlavor))
            {
                flavor.gameObject.SetActive(false);
            }
            else
            {
                flavor.gameObject.SetActive(true);
                flavor.text = c.cardFlavor;
            }

            artist.text = c.artist;
            art.sprite = c.art;
            */
        }

        public CardVizProperties GetProperties(Element e)
        {
            CardVizProperties result = null;

            for (int i = 0; i < properties.Length; i++)
            {
                if(properties[i].element == e)
                {
                    result = properties[i];
                    break;
                }
            }
            return result; 
        }
    }
}