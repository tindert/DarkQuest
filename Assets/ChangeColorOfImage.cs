using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeColorOfImage : MonoBehaviour
{
	public Image image;
	public Color targetColor = Color.red;
	public float duration = 2f;

	public float t = 0f; // Interpolation progress

	private void Update()
	{
		//t += Time.deltaTime / duration; // Increment the interpolation progress based on time

		// Interpolate between white and red based on the t value
		Color currentColor = Color.Lerp(Color.white, targetColor, t);

		// Set the color of the UI Image
		image.color = currentColor;
		
		image.fillAmount = t;



	}
}
