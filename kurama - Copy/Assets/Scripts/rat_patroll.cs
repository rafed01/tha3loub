using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rat_patroll : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private Vector3[] positions;
    private int index;

    // Update is called once per frame
    void Update()
    {
        //Move towards position
        transform.position = Vector2.MoveTowards(transform.position, positions[index], Time.deltaTime * speed);

        //If position is the same we want to go to, reset or increment
        if (transform.position == positions[index])
        {

            //Hitting a left limit
            if (index == 0)
            {
                Flip();
                index++;
            }
            //Hitting a right limit
            else if (index == positions.Length - 1)
            {
                Flip();
                index = 0;
            }
            else
            {
                index++;
            }
        }

    }

    void Flip()
    {
        Vector3 currentScale = gameObject.transform.localScale;
        currentScale.x *= -1;
        gameObject.transform.localScale = currentScale;
        
    }
}
