using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public abstract class CardType : ScriptableObject
    {
        public string typename;
        public virtual void OnSetType(CardViz viz)
        {
            Element t = Settings.GetResourcesManager().typeElement;
            CardVizProperties type = viz.GetProperties(t);
            type.text.text = typename;
        }

    }
}
 