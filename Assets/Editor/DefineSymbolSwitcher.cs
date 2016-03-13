using UnityEngine;
using System.Collections;

public class DefineSymbolSwitcher : MonoBehaviour {

	public Vector3 lookAtPoint = Vector3.zero;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(lookAtPoint);
	}
}
