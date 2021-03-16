 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayScript : MonoBehaviour
{
    public GameObject[] myArrayObjects = new GameObject[1];
    public GameObject roundParent;
    void Start()
    {
       

        int randomFood = Random.Range(0, 5);

       GameObject food = Instantiate(myArrayObjects[randomFood], this.transform.position, Quaternion.identity);

        food.transform.SetParent(roundParent.transform);
        Debug.Log("The name of the object is:" + randomFood);
    }

    
    void Update()
    {
        
    }
}
