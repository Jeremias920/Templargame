using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	
	public float walkspd = 10.0f;
	public bool walkdrct = true;
	public bool onramp = false;
	public bool walking = true;
	public LayerMask mask;
	public GameObject platform;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (walking && walkdrct) // walking right
		{
			RaycastHit2D hit = Physics2D.Raycast(platform.transform.position, -Vector3.up);
			Ray2D ray = new Ray2D(transform.position, -Vector3.up + Vector3.right);
			
			if(Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, mask))
			{
				if (hit.collider.tag == "platform")
				{
					transform.position += transform.right * walkspd * Time.deltaTime;
				}
			}
			else 
			{
				walkdrct = false;
			}
			
		} 
		
		
		if (walking && !walkdrct) // walking left
			
		{
			RaycastHit2D hit = Physics2D.Raycast(platform.transform.position, -Vector3.up);
			Ray2D ray = new Ray2D(transform.position, -Vector3.up + -Vector3.right);
			
			if(Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, mask))
			{
				if (hit.collider.tag == "platform")
				{
					transform.position -= transform.right * walkspd * Time.deltaTime;
				}
			}
			else
				
			{
				walkdrct = true;
			}
		}
		
	} 
}
