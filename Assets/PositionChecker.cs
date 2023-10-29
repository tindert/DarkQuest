using UnityEngine;

public class PositionChecker : MonoBehaviour
{
	public Transform tobject;
	
	public float speed = 1f;
	public float variable = 0f;

	private void Update()
	{
		if (tobject.position.y < -2f)
		{
			if (variable < 1)
			variable += speed * Time.deltaTime;
		}
		else
		{
			if (variable > 0)
			variable -= speed * Time.deltaTime;
		}
		
	}
}
