using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoleMole
{
    public class Test : AnimateView
    {

        // Use this for initialization
        void Start()
        {
            Singleton<ContextManager>.Instance.Push(new MainMenuPanelContext());
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
