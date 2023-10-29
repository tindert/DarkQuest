   using UnityEngine;

   public class GameObjectActivator : MonoBehaviour
   {
	   public GameObject[] objectsToActivate;
	   public GameObject[] objectsToDeactivate;


	   public void SwitchActivuty()
	   {
		   foreach (GameObject obj in objectsToActivate)
		   {
			   obj.SetActive(true);
		   }

		   foreach (GameObject obj in objectsToDeactivate)
		   {
			   obj.SetActive(false);
		   }

	   }
   }
