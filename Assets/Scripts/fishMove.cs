using UnityEngine;
using System.Collections;

public class fishMove : MonoBehaviour {

    public Animator sardineAnimator;
    private Vector3 finalDest;
    public Vector3 pos;
    public float forwardSpeed = 2.0f;
    private  float roamRadius = 15.0f;
    

    // Use this for initialization
    void Start () {
        sardineAnimator = GetComponent<Animator>();
        sardineAnimator.SetFloat("Forward", forwardSpeed);
        pos = gameObject.transform.position;
        
	}
	
	// Update is called once per frame
	void Update () {
        
        if (finalDest.x == 0 || Vector3.Distance(pos, finalDest) <= 10.2f)
            randomDir();

        var rotation = Quaternion.LookRotation(finalDest - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
        transform.Translate(0, 0, Time.deltaTime * forwardSpeed);
        pos = gameObject.transform.position;

    }
    public void randomDir(){
        Vector3 randomDirection = Random.insideUnitSphere * roamRadius;        
        randomDirection += pos;
        if (randomDirection.y > 12.0f)
            randomDirection.y = 11.5f;
        else if(randomDirection.y < 1.0f)
            randomDirection.y = 1.0f;

        finalDest = randomDirection;
    }

    void OnCollisionEnter(Collision hit){
        if (hit.transform.gameObject.name == "Terrain") {
            randomDir();
        }
    }
}
