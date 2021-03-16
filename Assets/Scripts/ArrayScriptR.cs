using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ArrayScriptR : MonoBehaviour
{
    public GameObject[] myArrayObjects = new GameObject[1];
    
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;

    List<int> numbersToChooseFrom = new List<int>(new int[] { 1, 2, 3, 4 });

    void Start()
    {

        Panel1.gameObject.SetActive(true);
        Panel2.gameObject.SetActive(false);
        Panel3.gameObject.SetActive(false);

        int randomFood1 = Random.Range(0, 5);

        GameObject food = Instantiate(myArrayObjects[randomFood1], this.transform.position, Quaternion.identity);

        
        

        //removes last number from array
        numbersToChooseFrom.Remove(randomFood1);
        //int randomNumber = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];






    }


    void Update()
    {
       
    }




    public void OnNextButton()
    {
        Panel1.gameObject.SetActive(false);
        Panel2.gameObject.SetActive(true);
        Panel3.gameObject.SetActive(false);


        int randomNumber = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
        int randomFood2 = randomNumber;
        GameObject Food2 =Instantiate(myArrayObjects[randomFood2], this.transform.position, Quaternion.identity);
        numbersToChooseFrom.Remove(randomFood2);
        Debug.Log("Round 2");

    }
    public void OnNextlastRound()
    {
        
        Panel1.gameObject.SetActive(false);
        Panel2.gameObject.SetActive(false);
        Panel3.gameObject.SetActive(true);
        int randomNumber = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
        int randomFood3 = randomNumber;
        Instantiate(myArrayObjects[randomFood3], this.transform.position, Quaternion.identity);
        Debug.Log("Round 3");
    }

}
