using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class mouseCtrlScr : MonoBehaviour
{
    private GameObject panel;
    private Text name, age, desc, loc;
    private treeProps tp;
    private animProps ap;
    private Renderer rend;

    public float pauseTime = 0.1f;

    // Use this for initialization
    void Start() {
        panel = GameObject.Find("/Canvas/Info Panel");

        name = GameObject.Find("/Canvas/Info Panel/Name").GetComponent<Text>();
        age = GameObject.Find("/Canvas/Info Panel/Age").GetComponent<Text>();
        desc = GameObject.Find("/Canvas/Info Panel/Desc").GetComponent<Text>();
        loc = GameObject.Find("/Canvas/Info Panel/Loc").GetComponent<Text>();
        
        panel.SetActive(false);
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update() {
        if (!Cursor.visible)
            return;

        Ray cr = Camera.current.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(cr, out hit, 15)){            
            if (hit.transform.tag == "Tree") {
                rend = hit.transform.gameObject.GetComponent<Renderer>();
                rend.material.shader = Shader.Find("AlphaSelfIllum");

                panel.SetActive(true);
                tp = hit.transform.gameObject.GetComponent<treeProps>();
                setText(tp.Name, tp.Age, tp.Desciption);
                
            }
            else if (hit.transform.tag == "Animal"){
                string name;
                if (hit.transform.name == "deer")
                    name = "Deer";
                else if (hit.transform.name == "bear")
                    name = "Bear";
                else
                    name = "Rabbit";

                rend = hit.transform.Find(name).GetComponent<Renderer>();
                rend.material.shader = Shader.Find("AlphaSelfIllum");


                panel.SetActive(true);
                ap = hit.transform.gameObject.GetComponent<animProps>();
                setText(ap.Name, ap.Age, ap.Desciption, ap.Location);
                
            }
        }
        else {
            if(panel.activeSelf) panel.SetActive(false);
            setTextBlank();
            rend.material.shader = Shader.Find("Legacy Shaders/Diffuse");
        }
        
    }

    private void setTextBlank() {
        name.text = "";
        age.text = "";
        desc.text = "";
        loc.text = "";
    }

    private void setText(string name, int age, string desc, string loc = null)
    {
        this.name.text = "Meno: " + name;
        this.age.text = "Vek: " + age.ToString();
        this.desc.text = "Popis: " + desc;

        if(loc != null)
            this.loc.text = "Lokácia: " + loc;
    }
}
