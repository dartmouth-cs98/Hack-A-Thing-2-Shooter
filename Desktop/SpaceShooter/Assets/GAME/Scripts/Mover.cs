/**Written with help of Tutorial for CS 98 by Hanting Guo
September 27th, 2018**/

using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
	public float speed;

	void Start ()
	{
		GetComponent<Rigidbody>().velocity = transform.forward * speed;
	}
}
