using UnityEngine;
using System.Collections;

public class SardineCharacter : MonoBehaviour {
	public Animator sardineAnimator;
	Rigidbody sardineRigid;
	public float turnSpeed=5f;
	public float forwardSpeed=5f;

    private Vector3 spawn;
    public Vector3 pos;

    void Start () {
		sardineAnimator = GetComponent<Animator> ();
		sardineAnimator.SetFloat ("Forward", forwardSpeed);
		sardineRigid = GetComponent<Rigidbody> ();

        pos = gameObject.transform.position;
        
    }

    
    void Update(){

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (pos.y >= 11.5f) {
            h = 0.8f;
            v = 0.5f;
        }

        Move(v, h);

    }
    public void setForwardSpeed(float fSpeed){
		forwardSpeed = fSpeed;
		sardineAnimator.SetFloat ("Forward", forwardSpeed);
	}

	public void Move(float v,float h){
        sardineAnimator.SetFloat ("Up", -v);
		sardineAnimator.SetFloat ("Turn", h);
        
        
        sardineRigid.AddForce (transform.forward*forwardSpeed);
		sardineRigid.AddTorque (transform.right*turnSpeed*v);
        sardineRigid.AddTorque (transform.up*turnSpeed*h);
	}
}
