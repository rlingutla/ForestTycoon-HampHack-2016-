using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class BottomPanel : MonoBehaviour
{
    private float panelWidthFactor = .16f;

    public int animals;
    public int oaks;
    public int pine;
    public int soil;
    public int totalTree;
    public GameObject Animal;
    public GameObject Pine;
    public GameObject Oak;
    public GameObject Soil;
    public Text text;
    private float time;
    private float issueTime;
    private float panelHeightFactor = .8f;
    private bool drawBox = true;
    private bool drawProblems = false;
    private bool buttona = false;
    //arrays with questions and answers 
    private string[] dangers = { "a", "b", "c", "d" };
    public int forestPoints;
    private double forestH = 15;
    int qIndex = 0;
    //arrays with questions and answers 
    private string[] Dangers = { "a", "b", "c", "d" };
    private string[] questions = {"What would cause the firefighters to put a fire out?",
                                 "Which is NOT a common cause of wildfires?",
                                 "The types of a forest fire are: ",
                                 "What are large patches of dead trees good for?",
                                 "How do fires affect the soil?"};
    private string[] answers = {"If there is a threat to human life or property","Animals", "Low intensity and crown fire/high intesity", "Homes for certain animals", "Cause the soil to absorb less water leading to erosion","add nutrients, like carbon, to the soil"};
    private string[] A = { "Any fire that is started", "lightening", "Natural and Man-Made", "Homes for certain animals", "always sterilizes the soil of any nutrients" };
    private string[] B = { "If there is a threat to human life or property","human carelessness", "Low intensity and crown fire/high intesity", "nothing", "nothing, itis just dirt"};
    private string[] C = { "only if the fire was caused by humans", "volcano eruption", "only one type: forest fires", "keeping wildfires down or away from living trees", "cause the soil to absorb less water leading to erosion"};
    private string[] D = {"Nothing", "Animals", "rainforest vs forests", "making the landscape ugly", "add nutrients, like carbon, to the soil"};
   

    // Use this for initialization
    void Start()
    {
        print(Screen.width);
        print(Screen.height);

        var a = GameObject.Find("Animal_6");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Animal_7");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Animal_8");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Animal_9");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Animal_10");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        animals = 5;

        oaks = 5;
        pine = 5;
        soil = 5;
        totalTree = 10;

        a = GameObject.Find("Oak_6" + "/Cylinder");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Oak_6" + "/Sphere");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Oak_7" + "/Cylinder");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Oak_7" + "/Sphere");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Oak_8" + "/Cylinder");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Oak_8" + "/Sphere");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Oak_9" + "/Cylinder");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Oak_9" + "/Sphere");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Oak_10" + "/Cylinder");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Oak_10" + "/Sphere");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Oak_11" + "/Cylinder");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Oak_11" + "/Sphere");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));

        a = GameObject.Find("Pine_6"+ "/Cylinder (1)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_6" + "/Cone_HP");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_6" + "/Cone_HP (1)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_6" + "/Cone_HP (2)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_6" + "/Cone_HP (3)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));

        a = GameObject.Find("Pine_7" + "/Cylinder (1)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_7" + "/Cone_HP");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_7" + "/Cone_HP (1)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_7" + "/Cone_HP (2)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_7" + "/Cone_HP (3)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));

        a = GameObject.Find("Pine_8" + "/Cylinder (1)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_8" + "/Cone_HP");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_8" + "/Cone_HP (1)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_8" + "/Cone_HP (2)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_8" + "/Cone_HP (3)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));

        a = GameObject.Find("Pine_9" + "/Cylinder (1)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_9" + "/Cone_HP");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_9" + "/Cone_HP (1)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_9" + "/Cone_HP (2)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_9" + "/Cone_HP (3)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));

        a = GameObject.Find("Pine_10" + "/Cylinder (1)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_10" + "/Cone_HP");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_10" + "/Cone_HP (1)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_10" + "/Cone_HP (2)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_10" + "/Cone_HP (3)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));

        a = GameObject.Find("Pine_11" + "/Cylinder (1)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_11" + "/Cone_HP");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_11" + "/Cone_HP (1)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_11" + "/Cone_HP (2)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        a = GameObject.Find("Pine_11" + "/Cone_HP (3)");
        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));

        print(Time.deltaTime);
        setIssueTime();
        time = 2;
        forestPoints = 0;
        forestH = ((animals + totalTree + soil) * 100 / (10 + 22 + 10));
        qIndex = (int)UnityEngine.Random.Range(0, 4);
        print(qIndex);



    }

    // Update is called once per frame
    void Update()
    {
        if (!drawProblems)
        {
            drawBox = true;
            qIndex = (int)UnityEngine.Random.Range(0, 4);
        }
        else {
            drawBox = false;
        }
    }


    void FixedUpdate()
    {

        time += Time.deltaTime;
        if (time >= issueTime)
        {
            drawProblems = true;
            drawBox = false;
        }

        forestH = ((animals + totalTree + soil) * 100 / (10 + 22 + 10));
    }

    void OnGUI()
    {
        GUI.Box(new Rect(Screen.width * panelWidthFactor, Screen.height - (Screen.height * 2 * panelWidthFactor), Screen.width - (Screen.width * 2 * panelWidthFactor), Screen.height * 2 * panelWidthFactor), "Forest Health Control Center");
        wildlifePush(GUI.Button(new Rect(Screen.width / 6, Screen.height - (Screen.height * 3 / 2 * panelWidthFactor), Screen.width / 6, 2 * (Screen.height - (Screen.height * 6 * panelWidthFactor))), "Wildlife"));
        varietyPush(GUI.Button(new Rect(Screen.width / 3, Screen.height - (Screen.height * 3 / 2 * panelWidthFactor), Screen.width / 6, 2 * (Screen.height - (Screen.height * 6 * panelWidthFactor))), "Tree Variety"));
        nutrientPush(GUI.Button(new Rect(Screen.width / 2, Screen.height - (Screen.height * 3 / 2 * panelWidthFactor), Screen.width / 6, 2 * (Screen.height - (Screen.height * 6 * panelWidthFactor))), "Soil Health"));
        numberPush(GUI.Button(new Rect(2 * Screen.width / 3, Screen.height - (Screen.height * 3 / 2 * panelWidthFactor), Screen.width / 6, 2 * (Screen.height - (Screen.height * 6 * panelWidthFactor))), "Tree Total"));
        GUI.TextField(new Rect(Screen.width / 6, Screen.height - (Screen.height * panelWidthFactor), Screen.width / 6, 2 * (Screen.height - (Screen.height * 6 * panelWidthFactor))), animals.ToString());
        GUI.TextField(new Rect(Screen.width / 3, Screen.height - (Screen.height * panelWidthFactor), Screen.width / 6, 2 * (Screen.height - (Screen.height * 6 * panelWidthFactor))), oaks + " oaks : " + pine + " pines");
        GUI.TextField(new Rect(Screen.width / 2, Screen.height - (Screen.height * panelWidthFactor), Screen.width / 6, 2 * (Screen.height - (Screen.height * 6 * panelWidthFactor))), soil.ToString());
        GUI.TextField(new Rect(2 * Screen.width / 3, Screen.height - (Screen.height * panelWidthFactor), Screen.width / 6, 2 * (Screen.height - (Screen.height * 6 * panelWidthFactor))), totalTree.ToString());
        GUI.Box(new Rect(0, Screen.height - (Screen.height * 2 * panelWidthFactor), Screen.width * panelWidthFactor, Screen.height - (Screen.height * 2 * panelWidthFactor)), "Forest Health");
        GUI.TextField(new Rect(0, Screen.height - (Screen.height * 3 / 2 * panelWidthFactor), Screen.width * panelWidthFactor, 2 * (Screen.height - (Screen.height * 6 * panelWidthFactor))), "Forest Health =" + forestH);
        GUI.TextField(new Rect(0, Screen.height - (Screen.height * panelWidthFactor), Screen.width * panelWidthFactor, 2 * (Screen.height - (Screen.height * 6 * panelWidthFactor))), "Forest Points = " + forestPoints);


        GUIStyle styleB = "box";
        styleB.wordWrap = true;
        GUIStyle styleBu = "button";
        styleBu.wordWrap = true;

        string DangerText = "Oh no! It seems as though some kids were careless when putting out a fire! suddenly trees were being in engulfed in flames! Help stop the fire and save the careless kids!";
        if (drawBox)
        {
            GUI.Box(new Rect(0, 0, Screen.width * panelWidthFactor, Screen.height - (Screen.height * 2 * panelWidthFactor)), "Danger Panel");
            GUI.Box(new Rect(Screen.width - Screen.width * panelWidthFactor, 0, Screen.width * panelWidthFactor, Screen.height), "Question");
        }
        if (drawProblems)
        {
            GUI.Box(new Rect(0, 0, Screen.width * panelWidthFactor, Screen.height - (Screen.height * 2 * panelWidthFactor)), "Danger Panel\n\n" + DangerText);
            GUI.Box(new Rect(Screen.width - Screen.width * panelWidthFactor, 0, Screen.width * panelWidthFactor, Screen.height), "Question\n"
                + questions[qIndex]);

            AButton(GUI.Button(new Rect(Screen.width - (Screen.width * panelWidthFactor) + 20, Screen.height -360, Screen.width * panelWidthFactor - 40, 85), A[qIndex]));
            BButton(GUI.Button(new Rect((Screen.width - (Screen.width * panelWidthFactor)) + 20, Screen.height -270, Screen.width * panelWidthFactor - 40, 85), B[qIndex]));
            CButton(GUI.Button(new Rect((Screen.width - (Screen.width * panelWidthFactor)) + 20, Screen.height - 180, Screen.width * panelWidthFactor - 40, 85), C[qIndex]));
            DButton(GUI.Button(new Rect((Screen.width - (Screen.width * panelWidthFactor)) + 20, Screen.height-90, Screen.width * panelWidthFactor - 40, 85), D[qIndex]));

        }
       
    }
    public void AButton(bool buttonPressed)
    {
        if (buttonPressed)
        {
            if (answers[qIndex] == A[qIndex])
            {
                drawProblems = false;
                setIssueTime();
                time = Time.deltaTime;
                forestPoints = forestPoints + 2;
            }
            else
            {
                fail();
            }
        }
    }
    public void BButton(bool buttonPressed)
    {
        if (buttonPressed)
        {
            if (answers[qIndex] == B[qIndex])
            {
                drawProblems = false;
                setIssueTime();
                time = Time.deltaTime;
                forestPoints = forestPoints + 2;
            }
            else
            {
                fail();
            }
        }
    }
    public void DButton(bool buttonPressed)
    {
        if (buttonPressed)
        {
   
            if (answers[qIndex] == D[qIndex])
            {
                drawProblems = false;
                setIssueTime();
                time = Time.deltaTime;
                forestPoints = forestPoints + 2;
            }
            else
            {
                fail();
            }
        }
    }
    public void CButton(bool buttonPressed)
    {
        if (buttonPressed)
        {
            if (answers[qIndex] == C[qIndex])
            {
                drawProblems = false;
                setIssueTime();
                time = Time.deltaTime;
                forestPoints = forestPoints + 2;
            }
            else
            {
                fail();
            }
        }
    }
    public void wildlifePush(bool buttonPressed)
    {
        if (buttonPressed)
        {
            if (forestPoints > 0)
            {
                if (animals <= 9)
                {
                    animals++;
                    var a = GameObject.Find("Animal_" + animals);
                    a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.7882352f, 0.352941f, 0.117647f, 1));
                }
                forestPoints--;
            }
        } 
    }

    public void nutrientPush(bool buttonPressed)
    {
        if (buttonPressed)
        {
            if (forestPoints > 0)
            {
                if (soil <= 9)
                {
                    soil++;
                    var a = GameObject.Find("Ground (Plane)");
                    Color c = a.GetComponent<Renderer>().material.GetColor("_Color");
                    a.GetComponent<Renderer>().material.SetColor("_Color", new Color(c.r - 0.1f, c.g, c.b, 1));
                }
                forestPoints--;
            }
        }
    }
    public void varietyPush(bool buttonPressed)
    {
        if (buttonPressed)
        {
            if(forestPoints > 0) {
                if (totalTree <= 21)
                {
                    if (oaks > pine)
                    {
                        pine++;
                        var a = GameObject.Find("Pine_" + pine + "/Cylinder (1)");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));
                        a = GameObject.Find("Pine_" + pine + "/Cone_HP");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));
                        a = GameObject.Find("Pine_" + pine + "/Cone_HP (1)");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));
                        a = GameObject.Find("Pine_" + pine + "/Cone_HP (2)");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));
                        a = GameObject.Find("Pine_" + pine + "/Cone_HP (3)");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));
                        totalTree++;
                    }
                    else if (pine > oaks)
                    {
                        oaks++;
                        var a = GameObject.Find("Oak_" + oaks + "/Cylinder");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));
                        a = GameObject.Find("Oak_" + oaks + "/Sphere");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));
                        totalTree++;
                    }
                }
                forestPoints--;
            }
        }
    }

    public void numberPush(bool buttonPressed)
     {
        if (buttonPressed)
        {
            if (forestPoints > 0)
            {
                if (totalTree <= 21)
                {
                    float treeRandomizer = UnityEngine.Random.value;
                    totalTree++;
                    if (treeRandomizer > 0.5)
                    {
                        pine++;
                        var a = GameObject.Find("Pine_" + pine + "/Cylinder (1)");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));
                        a = GameObject.Find("Pine_" + pine + "/Cone_HP");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));
                        a = GameObject.Find("Pine_" + pine + "/Cone_HP (1)");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));
                        a = GameObject.Find("Pine_" + pine + "/Cone_HP (2)");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));
                        a = GameObject.Find("Pine_" + pine + "/Cone_HP (3)");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));

                    }
                    else
                    {
                        oaks++;
                        var a = GameObject.Find("Oak_" + oaks + "/Cylinder");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));
                        a = GameObject.Find("Oak_" + oaks + "/Sphere");
                        a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.0627451f, 0.82352941f, 0, 1));

                    }
                }
                forestPoints--;
            }
        }
        //forestHealth = ((animals + oaks + pine + soil) / (10 + 22 + 10)) * 100;
    }
    //randomized timer for when forest issues appear
    void setIssueTime()
    {
        issueTime = UnityEngine.Random.value * 10;
    }

    public void fail()
    {
        if (pine > 0 && oaks > 0)
        {
            float treeRandom = UnityEngine.Random.value;
            if (treeRandom > 0.5)
            {
                oaks--;
                totalTree--;
                var a = GameObject.Find("Oak_" + oaks + "/Cylinder");
                a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
                a = GameObject.Find("Oak_" + oaks + "/Sphere");
                a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
            }
            else
            {
                pine--;
                totalTree--;
                var a = GameObject.Find("Pine_" + pine + "/Cylinder (1)");
                a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
                a = GameObject.Find("Pine_" + pine + "/Cone_HP");
                a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
                a = GameObject.Find("Pine_" + pine + "/Cone_HP (1)");
                a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
                a = GameObject.Find("Pine_" + pine + "/Cone_HP (2)");
                a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
                a = GameObject.Find("Pine_" + pine + "/Cone_HP (3)");
                a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));

            }
        }
        else if (pine > 0)
        {
            pine--;
            totalTree--;
            var a = GameObject.Find("Pine_" + pine + "/Cylinder (1)");
            a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
            a = GameObject.Find("Pine_" + pine + "/Cone_HP");
            a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
            a = GameObject.Find("Pine_" + pine + "/Cone_HP (1)");
            a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
            a = GameObject.Find("Pine_" + pine + "/Cone_HP (2)");
            a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
            a = GameObject.Find("Pine_" + pine + "/Cone_HP (3)");
            a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        }
        else if (oaks > 0)
        {
            oaks--;
            totalTree--;
            var a = GameObject.Find("Oak_" + oaks + "/Cylinder");
            a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
            a = GameObject.Find("Oak_" + oaks + "/Sphere");
            a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        }
        if (soil > 0)
        {
            soil--;
            var a = GameObject.Find("Ground (Plane)");
            Color c = a.GetComponent<Renderer>().material.GetColor("_Color");
            a.GetComponent<Renderer>().material.SetColor("_Color", new Color(c.r + 0.1f, c.g, c.b, 1));
        }
        if (animals > 0)
        {
            animals--;
            var a = GameObject.Find("Animal_" + animals);
            a.GetComponent<Renderer>().material.SetColor("_Color", new Color(0, 0, 0, 0));
        }
    }
}
