using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{

    void FixedUpdate()
    {
        Vector3 newPosition = transform.position;
        newPosition.x -= 3 * Time.deltaTime;
        transform.position = newPosition;
        if (newPosition.x <= -3.3){
            transform.position = new Vector2(3.2f,Random.value*-6-1);
        }
    }
}
