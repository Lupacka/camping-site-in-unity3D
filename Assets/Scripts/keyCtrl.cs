using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class keyCtrl : MonoBehaviour
{
    private FirstPersonController fpc;
    private GameObject helpPanel;

    // Use this for initialization
    void Start()
    {
        fpc = GetComponent<FirstPersonController>();
        helpPanel = GameObject.Find("Help Panel");

        mouseLookCtrl(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (helpPanel.activeSelf == false)
            
        if (Input.GetKeyDown(KeyCode.LeftAlt)){
                //Cursor.visible = true;
                mouseLookCtrl(false);
            }
            else if (Input.GetKeyUp(KeyCode.LeftAlt)){
                //Cursor.visible = false;
                mouseLookCtrl(true);
            }
        
                

        if (Input.GetKeyDown(KeyCode.F1)){
            if (helpPanel.activeSelf){
                mouseLookCtrl(true);
            }else
                mouseLookCtrl(false);
            helpPanel.SetActive(!helpPanel.activeSelf);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

    }

    public void mouseLookCtrl(bool mouseMove) {
        Cursor.visible = !mouseMove;
        switch (mouseMove){
            case false:
                fpc.m_MouseLook.XSensitivity = 0;
                fpc.m_MouseLook.YSensitivity = 0;
                break;
            case true:
                fpc.m_MouseLook.XSensitivity = 2;
                fpc.m_MouseLook.YSensitivity = 2;
                break;
        }
    }
}
