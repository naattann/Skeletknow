using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCanvas : MonoBehaviour
{
    public GameObject nextCanvas;
    public GameObject thisCanvas;

    // Start is called before the first frame update

    void Start()
    {


        nextCanvas.SetActive(false);



    }
    public void Options()
    {
        nextCanvas.SetActive(true);
        thisCanvas.SetActive(false);


    }

}