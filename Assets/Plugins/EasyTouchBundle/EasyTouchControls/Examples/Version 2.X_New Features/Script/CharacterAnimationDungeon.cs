using UnityEngine;
using System.Collections;

public class CharacterAnimationDungeon : MonoBehaviour {

    public static CharacterAnimationDungeon _instance;
	private CharacterController cc;
	private Animator anim;

    void Awake()
    {
        _instance = this;
    }
	// Use this for initialization
	void Start () {
		
		cc= GetComponentInChildren<CharacterController>();
		anim = GetComponentInChildren<Animator>();
	}
	
	
	// Wait end of frame to manage charactercontroller, because gravity is managed by virtual controller
	void LateUpdate(){
		if (cc.isGrounded && (ETCInput.GetAxis("Vertical")!=0 || ETCInput.GetAxis("Horizontal")!=0)){
			//anim.CrossFade("soldierRun");
            anim.SetTrigger("Run");

		}
		
		if (cc.isGrounded && ETCInput.GetAxis("Vertical")==0 && ETCInput.GetAxis("Horizontal")==0){
		//	anim.CrossFade("soldierIdleRelaxed");
            anim.SetTrigger("Idle");

		}
		
		if (!cc.isGrounded){
			//anim.CrossFade("soldierFalling");
		}
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");
        }

	}
    public void HeroAttack()
    {
        Debug.Log("攻击");
        anim.SetTrigger("ComboAttack");
    }
}
