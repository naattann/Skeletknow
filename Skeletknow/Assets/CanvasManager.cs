using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject UICanvas;
    public GameObject EscCanvas;
    public GameObject FinishCanvas;

    // Start is called before the first frame update

    void Start()
    {


        UICanvas.SetActive(true);
        EscCanvas.SetActive(false);
        FinishCanvas.SetActive(false);
     
       



    }
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            
            UICanvas.SetActive(false);
            EscCanvas.SetActive(true);
            

        }

      



    }
}
