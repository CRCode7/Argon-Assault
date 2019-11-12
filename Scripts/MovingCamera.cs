using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    [SerializeField] int velocity;
    Vector3 movement;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        movement = Vector3.left * Time.deltaTime * velocity;
        transform.position = transform.position + movement;
    }
}
