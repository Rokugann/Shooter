using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour {
	
	public GameObject[] model;
	float moveSpeed = 1.0f;
	GameObject[] processObj = new GameObject[3];

	// Use this for initialization
	void Start () {
		processObj[0] = Instantiate (model[0]);
		processObj[0].transform.parent = gameObject.transform;
		processObj[1] = Instantiate (model[1]);
		processObj[1].transform.parent = gameObject.transform;
		processObj[1].transform.localPosition = GetNewInstancePosition(processObj[0], processObj[1]);
	}
	
	// Update is called once per frame
	void Update () {
		processObj[0].transform.Translate(-(Vector3.forward * moveSpeed * Time.deltaTime));
		processObj[1].transform.Translate(-(Vector3.forward * moveSpeed * Time.deltaTime));
	}

	Vector3 GetNewInstancePosition(GameObject previousObj, GameObject newObj) {
		float previousPos = previousObj.transform.localPosition.z;
		float previousSize = previousObj.GetComponent<Renderer> ().bounds.size.z;
		return new Vector3 (newObj.transform.localPosition.x, newObj.transform.localPosition.y, previousPos + previousSize);
	}
}
