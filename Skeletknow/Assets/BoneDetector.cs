using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BoneDetector : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TMP_InputField InputField1;
    public TextMeshProUGUI Text;
    public TextMeshProUGUI QuizText;
    public TextMeshProUGUI NameText;
    public GameObject FinishCanvas;
    List<GameObject> teeths = new List<GameObject>();

    int mode;
    int currentIterations = 0;
    int goodAnswers = 0;
    string goodAnswer = "  ";
    string goodAnswer1 = "";  
    int rand1;
    int rand2;
    GameObject[] teeths1;
    GameObject[] teeths2;


    // Start is called before the first frame update
    void Start()
    {
        mode = PlayerPrefs.GetInt("mode");

        switch (mode)
        {

            case 0:
                InputField1.transform.localScale = new Vector3(0f, 0f, 0f);
                NameText.text = "Click any tooth to see the name";
                break;

            case 1:
                ScoreText.text = "Score: " + goodAnswers + "/10";
                NameText.text = "Click any tooth";
                break;


            case 2:
                InputField1.transform.localScale = new Vector3(0f, 0f, 0f);
                ScoreText.text = "Score: " + goodAnswers + "/10";
                
                teeths1 = GameObject.FindGameObjectsWithTag("Lower");
                teeths2 = GameObject.FindGameObjectsWithTag("Upper");
                NameText.text = "Click any tooth to begin";
                for (int i = 0; i <= 15; i++)
                {

                    teeths[i] = teeths1[i];
                    teeths[i + 16] = teeths2[i];
                }

                FindRandom();
                

                break;

        }
        
    }

    // Update is called once per frame
    void Update()
    {

        switch (mode)

        {
            case 0:

                if (Input.GetMouseButtonDown(0))
                {
                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit))
                    {

                        if (hit.collider.gameObject.tag == "Lower" || hit.collider.gameObject.tag == "Upper")
                        {
                            string name = hit.collider.gameObject.name;
                            string parentName = hit.collider.gameObject.tag;
                            Text.text = parentName + " " + name;
                        }
                    }
                }



                break;
            case 1:
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        RaycastHit hit;
                        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);



                        if (Physics.Raycast(ray, out hit))
                        {

                            if (hit.collider.gameObject.tag == "Lower" || hit.collider.gameObject.tag == "Upper")
                            {

                                goodAnswer = hit.collider.gameObject.tag + " " + hit.collider.gameObject.name;
                                NameText.text = "Type in tooth name";
                            }

                        }

                    }
                }
                break;
            case 2:
                {

                   
                    if (Input.GetMouseButtonDown(0))
                        {
                       
                        RaycastHit hit;
                        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);



                        if (Physics.Raycast(ray, out hit))
                        {



                            if (hit.collider.gameObject.tag == "Lower" || hit.collider.gameObject.tag == "Upper")
                            {
                                goodAnswer = hit.collider.gameObject.tag + " " + hit.collider.gameObject.name;

                                if (goodAnswer1 == goodAnswer)
                                {
                                    goodAnswers++;
                                    ScoreText.text = "Your score: " + goodAnswers + "/10";
                                    FindRandom();

                                }
                                else
                                {
                                    FindRandom();
                                }


                            }
                        }
                
                    }

                }
                break;            
        }
    
    }
    
    public void FindRandom()
    {

         rand1 = Random.Range(0, 17);
         rand2 = Random.Range(0, 2);

        GameObject help;
        
        if (rand2 == 0)
        {
            help = teeths1[rand1];
            goodAnswer1 = help.tag + " " + help.name;
            NameText.text = goodAnswer1;
        }
        else 
        {
            help = teeths2[rand1];
            goodAnswer1 = help.tag + " " + help.name;
            NameText.text = goodAnswer1;
        }
          
        currentIterations++;

        if (currentIterations == 11)
        {
            QuizText.text = "Your score: " + goodAnswers + "/10";
            FinishCanvas.SetActive(true);

        }
    }

    public void CheckAnswer()
    {

        string answer = InputField1.text;

        if (answer == goodAnswer)

        {
            goodAnswers++;
            NameText.text = "Congratulation!";
        }
        else
        {
            NameText.text = "Incorrect!";
        }

        InputField1.text = " ";

        currentIterations++;
        ScoreText.text = "Score: " + goodAnswers + "/10";
        goodAnswer = goodAnswer1;
       

        if (currentIterations == 9)
        {

            FinishCanvas.SetActive(true);
            QuizText.text = "Your score: " + goodAnswers + "/10";

        }
    }   
}
