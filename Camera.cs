using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
     public Transform player;
    public Vector3 offset;
    
 
    public void Update()
    {
    transform.position = player.position + offset;
    }
}
