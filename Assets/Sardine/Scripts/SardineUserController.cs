using UnityEngine;
using System.Collections;

public class SardineUserController : MonoBehaviour {
	SardineCharacter sardineCharacter;
    private Vector3 spawn;
    public Vector3 pos;

	void Start () {
		sardineCharacter = GetComponent<SardineCharacter> ();
        
	}
	

	void Update () {


		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");
		sardineCharacter.Move (v,h);


	}
}
