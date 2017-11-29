using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 *	
 *  
 *
 *	by Xuanyi
 *
 */

namespace MoleMole
{
	public class GameRoot : MonoBehaviour {

        //public static GameRoot _instance;
        //void Awake()
        //{
        //    if (_instance == null)
        //    {
        //        _instance = this;
        //        DontDestroyOnLoad(this.transform.gameObject);
        //    }
        //    else
        //    {
        //        Destroy(this.transform.gameObject);
        //    }
        //}
        public void Start()
        {
            Singleton<UIManager>.Create();

            Singleton<ContextManager>.Create();
            Singleton<Localization>.Create();
            
        }

	}
}
