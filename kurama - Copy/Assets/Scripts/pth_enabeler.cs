using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class pth_enabeler : MonoBehaviour
{
    private GameObject playerObj = null;
    private GameObject enemyobj = null;
    private AIPath pt;
    public float active_distance = 5f;
    public float inactive_distance = 15f;
    private Vector3 e_o_p;
    
    private void Start()
    {
        pt = GetComponent<AIPath>();
        if (playerObj == null)
        {
            playerObj = GameObject.Find("Player");
        }
        if (enemyobj == null)
        {
            enemyobj = GameObject.Find("enemy_bird");
        }
        pt.enabled = false;
        e_o_p = enemyobj.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(enemyobj.transform.position.x - playerObj.transform.position.x) <= active_distance)  
           
        {
            pt.enabled = true;
        }
        if (Mathf.Abs(enemyobj.transform.position.x - playerObj.transform.position.x) >= inactive_distance)
        {
            enemyobj.transform.position = e_o_p;
            pt.enabled = false;
        }
    }
}
