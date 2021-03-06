using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemText : MonoBehaviour {
    public Transform popuptext;
    public static bool textstatus = false;

    private void OnMouseEnter()
    {
        if (textstatus == false)
        {
            if (gameObject.name == "coaltower")
            {
                popuptext.GetComponent<TextMesh>().text = "Basic tower\nLow health and damage\n" + GameObject.Find("CurrencyManager").GetComponent<currency>().basicPrice.ToString()
                    + "\nLose 0.1 Happiness per second";
            }
            else if (gameObject.name == "GasTower")
            {
                popuptext.GetComponent<TextMesh>().text = "Basic tower\nLow health and damage\n$10";
            }
            else if (gameObject.name == "cannon")
            {
                popuptext.GetComponent<TextMesh>().text = "Cannon with splash damage\nhigh damage\n" + GameObject.Find("CurrencyManager").GetComponent<currency>().cannonPrice.ToString() + "\nLose 0.1 Happiness per second"; ;
            } 
            else if (gameObject.name == "wall")
            {
                popuptext.GetComponent<TextMesh>().text = "Wall does no damage\nVery high health\n" + GameObject.Find("CurrencyManager").GetComponent<currency>().wallPrice.ToString() + "\nLose 0.1 Happiness per second"; ;
            }
            else if (gameObject.name == "buyKnockbackTower")
            {
                popuptext.GetComponent<TextMesh>().text = "Knocks back enemies\n" + GameObject.Find("CurrencyManager").GetComponent<currency>().knockbackPrice.ToString() + "\nLose 0.1 Happiness per second"; ;
            }
            else if(gameObject.name == "Upgrade")
            {
                int upgradePrice = 0;
                if(gameObject.transform.parent.CompareTag("tower"))
                {
                    if(gameObject.GetComponentInParent<TowerPosition>().towerType == "Basic")
                    {
                        upgradePrice = GameObject.Find("Upgrade").GetComponent<upgrade>().basicUpgradePrice;
                    }
                    if (gameObject.GetComponentInParent<TowerPosition>().towerType == "Wall")
                    {
                        upgradePrice = GameObject.Find("Upgrade").GetComponent<upgrade>().wallUpgradePrice;
                    }
                    if (gameObject.GetComponentInParent<TowerPosition>().towerType == "Cannon")
                    {
                        upgradePrice = GameObject.Find("Upgrade").GetComponent<upgrade>().cannonUpgradePrice;
                    }

                }
                else
                {
                    upgradePrice = 20;
                }
                
                popuptext.GetComponent<TextMesh>().text = "Upgrade: " + upgradePrice.ToString();
            }

            textstatus = true;
            Instantiate(popuptext, new Vector3(transform.position.x - 4, transform.position.y + 1, -1), popuptext.rotation);
        }

    }

    private void OnMouseExit()
    {
            textstatus = false;

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
  
  private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            textstatus = false;
        }
    }
}
