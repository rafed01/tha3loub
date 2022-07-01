using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{

	public Transform firepoint;
	public GameObject bulletspre;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetButtonDown("Fire1"))
		{
			Shoot();
			DestructionE();
			
		

		}
	}
	private void DestructionE()
	{
		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("impact");
		foreach (GameObject target in gameObjects)
		{
			GameObject.Destroy(target);
		}
	}
	

	void Shoot()
	{
		Instantiate(bulletspre, firepoint.position, firepoint.rotation);
	}
}
 