using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour
{
    // Start is called before the first frame update


    public void SetLearningMode()
    {
        PlayerPrefs.SetInt("mode", 0);

    }

    public void SetQuizMode()
    {
        PlayerPrefs.SetInt("mode", 1);

    }

    public void SetQuiz2Mode()
    {
        PlayerPrefs.SetInt("mode", 2);

    }


}
