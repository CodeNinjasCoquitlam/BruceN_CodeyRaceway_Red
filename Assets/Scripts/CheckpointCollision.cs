using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointCollision : MonoBehaviour
{
    public bool didCollide;
    public CheckpointCounter count;
    // Start is called before the first frame update
    void Start()
    {
        didCollide = false;
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag == "Player" && didCollide == false)
        {
            didCollide = true;
            count.triggeredCheckpoints++;
        }
    }
}
