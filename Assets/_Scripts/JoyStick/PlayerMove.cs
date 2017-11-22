using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
    private Animator anim;
    void Awake()
    {
        anim = GetComponentInChildren<Animator>();

    }
	void Start () {

       // ETCJoystick.On
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void Move()
    {

    }
    void MoveEnd()
    {

    }
}
