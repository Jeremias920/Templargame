using UnityEngine;
using System.Collections;

public class Digging : MonoBehaviour {

	public Transform rangeStart, rangeEnd;
	public bool digrange = false;

	void Update()
	{
		Raycasting ();
		Behaviours ();

	}

	void Raycasting()
	{
		Debug.DrawLine (rangeStart.position, rangeEnd.position, Color.red);
		digrange = Physics2D.Linecast (rangeStart.position, rangeEnd.position, 1 << LayerMask.NameToLayer("Ground"));
	}

	void Behaviours()
	{

	}
}
