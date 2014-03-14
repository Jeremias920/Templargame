using UnityEngine;
using System.Collections;

public class TemplarAi : MonoBehaviour {


	public bool wlkdrct = true;
	public float mvspd = 4.0f;
	public LayerMask mask;
	public GameObject wall;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

		print (mvspd);

		if (mvspd >= 4.0f) 
				{
					mvspd = 4.0f;
				}

		if (wlkdrct) //moves right
		{
			Debug.Log ("walking right");

			transform.position += Vector3.right * mvspd * Time.deltaTime;

			RaycastHit2D hit = Physics2D.Raycast(wall.transform.position, Vector3.right);
			Ray2D ray = new Ray2D(transform.position,Vector3.right);

			if(Physics2D.Raycast(ray.origin, ray.direction,1f,mask))
			{
				print(hit.collider.tag);
				if (hit.collider.tag == "wall")
				{
					wlkdrct = false;
					Debug.Log ("ray hitting wall");
				}

			}
			Debug.DrawRay(ray.origin, ray.direction * 1f, Color.cyan);
		}

		if (!wlkdrct) 
		{
			Debug.Log ("walking left");
			transform.position -= Vector3.right * mvspd * Time.deltaTime;

			RaycastHit2D hit = Physics2D.Raycast(wall.transform.position, Vector3.left);
			Ray2D ray = new Ray2D(transform.position,Vector3.left);

			if(Physics2D.Raycast(ray.origin, ray.direction,1f,mask))
			{
				print(hit.collider.tag);
				if (hit.collider.tag == "wall")
				{
					wlkdrct = true;
					Debug.Log ("ray hitting wall");
				}
			}
			Debug.DrawRay(ray.origin, ray.direction * 1f, Color.cyan);
		}


	}
}
