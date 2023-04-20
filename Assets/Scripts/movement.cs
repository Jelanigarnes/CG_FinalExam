using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public List<GameObject> movePoints;
    int currentMovepointIndex = 0;
    Vector3 targetPos;

    public int speed = 15;

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(movePoints[currentMovepointIndex].transform.position.z - transform.position.z) < .1f)
        {
            currentMovepointIndex++;
            if (currentMovepointIndex >= movePoints.Count)
            {
                currentMovepointIndex = 0;
            }
        }
        targetPos = new Vector3(transform.position.x, transform.position.y, movePoints[currentMovepointIndex].transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

   
}
