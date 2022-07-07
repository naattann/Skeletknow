using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{


    // Start is called before the first frame update
    public void Change()
    {

        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void ChangeToMenu()
    {

        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }


}
