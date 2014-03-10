#pragma strict

var moveleft : KeyCode;
var moveright : KeyCode;
var moveup : KeyCode;
var speed : float = 5;

function Update () 
{
	//rigidbody2D.AddForce (new Vector2 (80, 10));
	//rigidbody2D.velocity.x = speed;


	if (Input.GetKey(moveright))
	{
		rigidbody2D.velocity.x = speed;
	}
	else if (Input.GetKey(moveleft))
	{
		rigidbody2D.velocity.x = speed * -1;
	}
	else if (Input.GetKey(moveup))
	{
		rigidbody2D.velocity.y = speed;
	}
	else
	{
		rigidbody2D.velocity.x = 0;
	}
}