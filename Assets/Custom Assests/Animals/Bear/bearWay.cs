using UnityEngine;
using System.Collections;
using System;

public class bearWay : MonoBehaviour {

    public Transform[] waypoint;        
    public float patrolSpeed = 2.5f;     
    public bool loop = true;       
    public float dampingLook = 8.0f;          
    public float pauseDuration = 0;
    
    private float curTime;
    private int currentWaypoint = 1;

    void Start(){
        GameObject[] tmp = GameObject.FindGameObjectsWithTag("BW");
        Array.Sort(tmp, delegate(GameObject go1, GameObject go2) { return go1.name.CompareTo(go2.name); });
        if (tmp != null) fillWaypoints(tmp);

        

    }

    void Update() {

        if (currentWaypoint < waypoint.Length) {
            patrol();
        } else{

            if (loop) {
                currentWaypoint = 0;
            }
        }
    }

    void fillWaypoints(GameObject[] go) {
        waypoint = new Transform[go.Length];
        for (int i = 0; i < waypoint.Length; i++) {
            waypoint[i] = go[i].transform;
        }

    }

    void patrol() {

        Vector3 target = waypoint[currentWaypoint].position;
        target.y = transform.position.y; 
        Vector3 moveDirection = target - transform.position;

        if (moveDirection.magnitude < 0.5f) {

            if (curTime == 0)
                curTime = Time.time; 
            if ((Time.time - curTime) >= pauseDuration) {

                currentWaypoint++;
                curTime = 0;
            }
        } else  {
            var rotation = Quaternion.LookRotation(target - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * dampingLook);
            //character.Move(moveDirection.normalized * patrolSpeed * Time.deltaTime);
            transform.Translate(0, 0, Time.deltaTime * patrolSpeed);
        }
    }
}