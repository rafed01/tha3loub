using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collect : MonoBehaviour
{
    private double berryCount = 0;
    public Text counterbe;
    public Text lfcount;
    public sbyte lifecount = 1;
    public int nofberriestolives = 0;

    // Start is called before the first frame update
    void Start()
    {
        lfcount.text = "1";
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("collectable"))
        {
            berryCount += 0.5;
           // int i = (int)Mathf.Ceil((float)berryCount);

            Destroy(other.gameObject);

            counterbe.text = berryCount.ToString();
            
        }
        if (other.CompareTag("Enemy"))
        {
            lifecount -= 1;
        }
    }


    // Update is called once per frame
    private void Update()
    {
        if (berryCount >= nofberriestolives)
        {
            lifecount += 1;
            lfcount.text = lifecount.ToString();
            berryCount = 0;
            

        }
        if (lifecount <= 0)
        {
           
        }
    }

    
}
