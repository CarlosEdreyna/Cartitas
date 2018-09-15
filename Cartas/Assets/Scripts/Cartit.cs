using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cartit : MonoBehaviour {

    public Material[] randomMaterials;

    public GameObject[] card;

    // Use this for initialization
    void Start () {

        foreach (GameObject CardFBX in card)
        {
            CardFBX.GetComponent<Renderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)];
        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
