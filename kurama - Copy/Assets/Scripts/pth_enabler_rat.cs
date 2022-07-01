using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class pth_enabler_rat : MonoBehaviour
{
    private GameObject playerObj = null;
    private GameObject enemy_ratobj = null;
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
        if (enemy_ratobj == null)
        {
            enemy_ratobj = GameObject.Find("enemy_rat");
        }
        pt.enabled = false;
        e_o_p = enemy_ratobj.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(enemy_ratobj.transform.position.x - playerObj.transform.position.x) <= active_distance)

        {
            pt.enabled = true;
        }
        if (Mathf.Abs(enemy_ratobj.transform.position.x - playerObj.transform.position.x) >= inactive_distance)
        {
            enemy_ratobj.transform.position = e_o_p;
            pt.enabled = false;
        }
    }
}
