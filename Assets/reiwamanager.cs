using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;

public class reiwamanager : MonoBehaviour {
    [SerializeField] private GameObject reiwaText;

	// Use this for initialization
	void Start () {
        InteractionManager.InteractionSourceReleased += (obj) =>
        {
            var go = Instantiate(reiwaText);
            var box=go.GetComponent<Rigidbody>();
            go.transform.position = Camera.main.transform.position;
            box.AddForce(Camera.main.transform.forward*50.0f, ForceMode.VelocityChange);
        };
	}

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            var go = Instantiate(reiwaText);
            var box = go.GetComponent<Rigidbody>();
            go.transform.position = Camera.main.transform.position;
            box.AddForce(Camera.main.transform.forward * 50.0f,ForceMode.VelocityChange);
        }
	}
}
