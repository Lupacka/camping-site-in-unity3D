using UnityEngine;
using System.Collections;

public class carLightScr : MonoBehaviour
{

    private Light svetlo1, svetlo2;
    private GameObject svetla;
    // Use this for initialization
    void Start()
    {
        svetla = GameObject.Find("/car/Svetlomety");
        svetlo1 = GameObject.Find("/car/Svetlomety/Svetlo1").transform.GetChild(0).GetComponent<Light>();
        svetlo2 = GameObject.Find("/car/Svetlomety/Svetlo2").transform.GetChild(0).GetComponent<Light>();
        svetla.SetActive(false);
        svetlo1.enabled = false;
        svetlo2.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetMouseButtonDown(0)) {
            if (svetla.activeSelf) {

                svetla.SetActive(false);

            } else{

                svetla.SetActive(true);

            }
        }*/
    }
    void OnMouseDown()
    {
        svetla.SetActive(!svetla.activeSelf);
        svetlo1.enabled = !svetlo1.enabled;
        svetlo2.enabled = !svetlo2.enabled;
    }
}
