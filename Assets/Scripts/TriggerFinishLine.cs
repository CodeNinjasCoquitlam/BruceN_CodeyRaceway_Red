using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;
    public CountdownTimer countdownTimer;
    // Start is called before the first frame update
   private void OnTriggerEnter(Collider other)
   {
        if(other.gameObject.tag == "Player")
        {
            if (checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                print("You Win!");
                countdownTimer.Timer.text = "";
                
            }
            else
            {
                print("Cheater!");
            }
        }
       
   }

    // Update is called once per frame
    void Update()
    {
        
    }
}
