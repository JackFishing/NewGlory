using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionTest : MonoBehaviour {

    public GameObject Capsule;
    void Awake()
    {
        Capsule = GameObject.Find("Capsule").gameObject;
    }
	// Use this for initialization
	void Start () {
        bool IsTouch = CheckCircleAndCylinderCollider(this.transform.position.x, this.transform.position.y, this.transform.position.z, 1, Capsule.transform.position.x, Capsule.transform.position.y,
            Capsule.transform.position.z, 0.5f, 2);
        Debug.Log("是否击中怪物：" + IsTouch);
		
	}
	
	// Update is called once per frame
	void Update () {

        //bool IsTouch = CheckCircleAndCylinderCollider(this.transform.position.x, this.transform.position.y, this.transform.position.z, 1, Capsule.transform.position.x, Capsule.transform.position.y,
        //  Capsule.transform.position.z, 0.5f, 2);
        //Debug.Log("是否击中怪物：" + IsTouch);
	}
    public static bool CheckCircleAndCylinderCollider(float x1, float y1, float z1, float r1,
     float x2, float y2, float z2, float r2, float h2)
    {
        float dx = x2 - x1;
        float dy = y2 - y1;
        float dz = z2 - z1;
        float disSqua = (dx * dx) + (dz * dz);
        float rSqua = (r1 + r2) * (r1 + r2);
        bool heightCheck = Mathf.Abs(y1 - y2) < r1 + h2 / 2;
        return heightCheck && disSqua < rSqua;
    }
}
