using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoleMole
{
    public class NewBehaviourScript : AnimateView
    {

        // Use this for initialization
        void Start()
        {

            Singleton<ContextManager>.Instance.Push(new MenuContext());
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
