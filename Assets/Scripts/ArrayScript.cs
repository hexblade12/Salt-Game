 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    public GameObject[] myArrayObjects = new GameObject[1];
    void Start()
    {
       

        int randomFood = Random.Range(0, 2);

        Instantiate(myArrayObjects[randomFood], this.transform.position, Quaternion.identity);

        Debug.Log("The name of the object is:" + randomFood);
    }

    
    void Update()
    {
        
    }
}
