using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Posicion : MonoBehaviour {

    public Material[] randomMaterials;

    public GameObject[] card;


    // Use this for initialization
    void Start () {

        /*foreach (Material materials in randomMaterials)
        {
            foreach (GameObject CardFBX in card)
            {
                CardFBX.GetComponent<Renderer>().material = randomMaterials[Random.Range(0, randomMaterials.Length)];
            }
        }*/
        
        int[] indMat = new int[randomMaterials.Length];
        
        for (int i = 0; i < randomMaterials.Length; i++)
        {
            indMat[i] = 0; 
        }
        foreach (GameObject CardFBX in card)
        { 
            int num = Random.Range(0, randomMaterials.Length);
            
            while (indMat[num] != 0)
            {
                num++;
                if (num >= randomMaterials.Length)
                {
                    num = 0;
                }
            }
            indMat[num] = 1;
            CardFBX.GetComponent<Renderer>().material = randomMaterials[num];
        }
    }
        // Update is called once per frame
        void Update () {
		
	}
}
