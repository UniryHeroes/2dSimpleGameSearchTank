using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject tank;
    public GameObject fuel;
    public Text tankpostion;
    public Text fuelpostion;
    public Text energyAmt;
    public void AddEnergy(string amt)
    {
        int n;
        if (int.TryParse(amt, out n))
        {
            int c = int.Parse(energyAmt.text) + int.Parse(amt);

            energyAmt.text = c + "";
        }
        
    }

    void Start()
    {
        tankpostion.text = tank.transform.position.x + tank.transform.position.y +"";
        fuelpostion.text = fuel.GetComponent<ObjectManager>().objPosition + "";
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
