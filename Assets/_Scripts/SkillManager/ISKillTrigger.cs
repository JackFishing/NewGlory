using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface ISKillTrigger
{
    void Init(string args);
    void Reset();
    ISKillTrigger Clone();
    bool Execute(ISKillTrigger instance, float curTime);

}


//public class ISKillTrigger : MonoBehaviour {

//    // Use this for initialization
//    void Start () {
		
//    }
	
//    // Update is called once per frame
//    void Update () {
		
//    }
//}
