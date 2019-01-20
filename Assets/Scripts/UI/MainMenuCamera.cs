using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuCamera : MonoBehaviour
{
    public float[] Directions;
    public float Direction;
    public float TurnSpeed = 90;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If not facing 'Direction'
        if (transform.rotation.eulerAngles.y != Direction)
            transform.rotation = Quaternion.Euler(
                0, 
                Mathf.MoveTowardsAngle(transform.rotation.eulerAngles.y, Direction ,Time.deltaTime * TurnSpeed), 
                0);
    }

    public void FaceDirection(int i)
    {
        Direction = Directions[i];
    }
}
