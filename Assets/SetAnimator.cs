using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EasyButtons;


public class SetAnimator : MonoBehaviour
{
	[SerializeField]
	private Animator animator;
	
	public bool abool;

	private void Start()
	{
		animator = GetComponent<Animator>();
	}

	[Button]
	public void SetAnimatorUp()
	{
		animator.SetBool("IsGoingDown", abool);
		abool = !abool;
	}
	
}
