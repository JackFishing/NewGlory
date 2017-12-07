using UnityEngine;
using System.Collections;

public class CharacterAnimationDungeon : MonoBehaviour {

    public static CharacterAnimationDungeon _instance;
	private CharacterController cc;
	private Animator anim;
    public GameObject[] effects; 

  //  public GameObject ETC;
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
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Run"))
            {
                anim.SetBool("Run", true);
                anim.SetBool("Idle", false);

            }
            

		}
		
		if (cc.isGrounded && ETCInput.GetAxis("Vertical")==0 && ETCInput.GetAxis("Horizontal")==0){
            if (!anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
            {
                anim.SetBool("Idle", true);
                anim.SetBool("Run", false);
            }
           

		}
		
        //if (!cc.isGrounded){
        //    //anim.CrossFade("soldierFalling");
        //}
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    anim.SetTrigger("Jump");
        //}

	}
    public void HeroAttack(Vector3 pos)
    {
        anim.SetTrigger("ComboAttack");
        transform.LookAt(pos);
       // ETC.GetComponent<ETCJoystick>().isTurnAndMove = false;
    }
    public void EffectClone(Vector3 pos)
    {
        GameObject go = Instantiate(effects[2]) as GameObject;
        go.transform.localPosition = pos;

    }
}
