using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class panelControl : MonoBehaviour
{
    
    public GameObject Panel1;
    public GameObject Panel2;
    public GameObject Panel3;
    // Start is called before the first frame update
    void Start()
    {
        Panel1.gameObject.SetActive(true);
        Panel2.gameObject.SetActive(false);
        Panel3.gameObject.SetActive(false);
    }

    public void OnNextButton()
    {
        Panel1.gameObject.SetActive(false);
        Panel2.gameObject.SetActive(true);
        Panel3.gameObject.SetActive(false);
    }
    public void OnNextlastRound()
    {
        Panel1.gameObject.SetActive(false);
        Panel2.gameObject.SetActive(false);
        Panel3.gameObject.SetActive(true);
    }
}
