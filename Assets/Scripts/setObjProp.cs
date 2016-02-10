using UnityEngine;
using System.Collections;

public class setObjProp: MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        setAnimProp();
        setTreeProp();        	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void setAnimProp()
    {
        animProps ap;
        GameObject[] go = GameObject.FindGameObjectsWithTag("Animal");

        for (int i = 0; i < go.Length; i++)
        {
            ap = go[i].GetComponent<animProps>();
            if (ap != null)
            {
                if (go[i].name.Contains("bear"))
                {
                    ap.Name = "Medveď hnedý";
                    ap.Location = "Yukon, Aljaška, Severná Amerika, Európa";
                    ap.Desciption = "Dospelý medveď dorastá do dĺžky od 2 do 3 m, chvost meria 5 až 20 cm a dosahuje hmotnosti od 100 až po 350 kg. Medvede hnedé sú silne stavané s typickým svalnatým hrbom v oblasti lopatiek. Na labách má nezatiahnuteľné pazúry. Pohlavný dimorfizmus vo veľkosti je veľmi malý, ale samce bývajú dvakrát ťažšie ako samice, ktoré majú menšie a ľahšie kosti. Srsť medveďov hnedých je tmavohnedá, blond až čierna. Vo voľnej prírode sa dožívajú 25 rokov, v zajatí o niečo viac.";
                    ap.Age = Random.Range(5, 25);
                }
                else if (go[i].name.Contains("deer"))
                {
                    ap.Name = "Jeleň lesný";
                    ap.Location = "Severná Amerika, Európa, Malá Ázia";
                    ap.Desciption = "Jeleň lesný patrí medzi najväčších zástupcov svojej čeľade. Samce dorastajú do 175 – 230 cm a ich hmotnosť sa pohybuje medzi 160 – 240 kg. Samice sú oproti samcom výrazne menšie, dorastajú do 160 – 210 cm a dosahujú hmotnosť medzi 120 – 170 kg. Chvost pritom meria 12 – 19 cm a v kohútiku dosahujú výšku 120 až 150 cm.";
                    ap.Age = Random.Range(1, 25);
                }
                else if (go[i].name.Contains("zajac"))
                {
                    ap.Name = "Zajac poľný";
                    ap.Location = "Európa, Západná Ázia";
                    ap.Desciption = " je druh zajaca a pôvodný druh zo severnej, centrálnej, západnej Európy a západnej Ázie. Ako originálny druh sa dnes však vyskytuje napr. aj na území Južnej Ameriky alebo v Austrálii. Jeho prirodzeným biotopom sú otvorené krajiny, predovšetkým polia, lúky, okraje lesov,kde je vďaka svojmu hnedému sfarbeniu veľmi dobre maskovaný.";
                    ap.Age = Random.Range(1, 10);
                }
            }
        }
    }

    private void setTreeProp(){
        treeProps tp;
        GameObject[] go = GameObject.FindGameObjectsWithTag("Tree");

        for (int i = 0; i < go.Length; i++)
        {
            tp = go[i].GetComponent<treeProps>();
            if (tp != null)
            {
                if (go[i].name.Contains("tree3"))
                {
                    tp.Name = "Figovník sykomorový";
                    tp.Desciption = "Je to strom, ktorý pochádza z Afriky a je od pradávna pestovaný. Pôvodný je v oblasti južne od Sahary a v južnej Arábii, dnes je bežný napr. V Egypte, kde bol považovaný za posvätný strom a jeho drevo sa používalo na výrobu truhiel.";
                    tp.Age = Random.Range(10, 100);
                }
                else if (go[i].name.Contains("tree1"))
                {
                    tp.Name = "Jaseň";
                    tp.Desciption = "Jaseň (Fraxinus) je rod listnatých stromov z čeľade olivovité. a území Slovenska sa vyskytujú dva druhy: najrozšírenejší jaseň štíhly (Fraxinus excelsior) a jaseň mannový (Fraxinus ornus). Mohutné jasene ešte v 90-tych rokoch min. st. rástli v masíve Popričného (995 m n. m.; Vihorlatské vrchy).";
                    tp.Age = Random.Range(10, 100);
                }
                else if (go[i].name.Contains("tree2"))
                {
                    tp.Name = "Agát biely";
                    tp.Desciption = "Agát biely (Robinia pseudoacacia) je drevina z čeľade bôbovité (Fabaceae). Dorastá do výšky 20 až 25 metrov, má stredne rozkonárenú nepravidelnú korunu. Voľne v prírode pravidelne a bohato nasadzuje množstvo semien, ktoré sa ľahko ujímajú. Pri šľachtení sa agát rozmnožuje najmä zelenými a koreňovými odrezkami pre cenné zachovanie dedičných vlastností.";
                    tp.Age = Random.Range(10, 100);
                }
                else if (go[i].name.Contains("ScotsPineTypeA"))
                {
                    tp.Name = "Borovica lesná";
                    tp.Desciption = "Borovica lesná (staršie: borovica sosna, (?) borovica sosnová; skrátene: sosna; Pinus sylvestris alebo Pinus silvestris) je ihličnatý strom s mohutným, hlboko idúcim hlavným koreňom a široko rozostretou až plochou korunou.";
                    tp.Age = Random.Range(10, 100);
                }
            }
        }
    }
}
