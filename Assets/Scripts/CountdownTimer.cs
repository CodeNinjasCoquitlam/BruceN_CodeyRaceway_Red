using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{

    public Text Timer;
    public Text StartingTimer;

    public float totalLapTime;
    public float totalCountdownTime;
    public CodeyMove codeyMove;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        


        Timer.text = Mathf.Round(totalLapTime).ToString();
        StartingTimer.text = Mathf.Round(totalCountdownTime).ToString();

        if(totalCountdownTime < 0)
        {
            totalLapTime -= Time.deltaTime;
        }

        if(totalLapTime < 0)
        {
            Timer.text = "";
            print("TIMES UP LOSER");
        }
        

        if (totalCountdownTime > 0)
        {
            totalCountdownTime -= Time.deltaTime;
            codeyMove.Speed = 0f;

        }

        if (totalCountdownTime < 0)
        {
            StartingTimer.text = "";
            codeyMove.Speed = 20f;
            
        }
    }
}
