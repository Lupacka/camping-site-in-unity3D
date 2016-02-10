using UnityEngine;
using System.Collections;

public class helpPanelClose : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void Close() {
        gameObject.SetActive(false);
        keyCtrl k = GameObject.Find("FPSController").GetComponent<keyCtrl>();
        k.mouseLookCtrl(true);
    }
}
