using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class get_collected : MonoBehaviour
{

    private double berryCount = 0;
    public Text counterbe;
    
  

    public void OnTriggerEnter2D(Collider2D collision)
    {
        berryCount = berryCount + 0.5;
        counterbe.text = berryCount.ToString();
        //Destroy(gameObject);
    }
    

}
