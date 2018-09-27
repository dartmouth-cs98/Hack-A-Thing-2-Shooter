/**Written with help of Tutorial for CS 98 by Hanting Guo
September 27th, 2018**/

using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour
{
	void OnTriggerExit (Collider other) 
	{

		
		Destroy(other.gameObject);
	}
}