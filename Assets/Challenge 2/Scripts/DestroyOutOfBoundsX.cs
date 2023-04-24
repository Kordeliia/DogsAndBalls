using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5;

    // Update is called once per frame
    void Update()
    {
        bool cond1 = transform.position.x < leftLimit;
        bool cond2 = transform.position.y < bottomLimit;
        // Destroy dogs if x position less than left limit
        if (cond1)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (cond2)
        {
            Destroy(gameObject);
            Debug.Log("Game overcito");
            Time.timeScale = 0f;
        }

    }
}
