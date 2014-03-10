using UnityEngine;
using System.Collections;

public class ClickToDig : MonoBehaviour {

	public Transform rangeStart, rangeEnd;
	public bool interact = false;

	RaycastHit2D Shoveling;

	void Update ()
	{
		Raycasting ();
	}

	void Raycasting ()
	{
		Debug.DrawLine (rangeStart.position, rangeEnd.position, Color.green);

		if (Physics2D.Linecast (rangeStart.position, rangeEnd.position, 1 << LayerMask.NameToLayer ("platform"))) 
				{
						Shoveling = Physics2D.Linecast (rangeStart.position, rangeEnd.position, 1 << LayerMask.NameToLayer ("platform"));
						interact = true;
				} 
		else 
		{
			interact = false;
		}

		if (Input.GetMouseButton (0) && interact == true) 
		{
			Debug.Log("Pressed left click.");
			Destroy (Shoveling.collider.gameObject);
		}
		
	}
	}

