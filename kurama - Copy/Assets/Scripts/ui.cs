using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ui : MonoBehaviour
{
    public Text Score;
   private int scorevar = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scorevar += 1;
        Score.text = scorevar.ToString();
    }
}
