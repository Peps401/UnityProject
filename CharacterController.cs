using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 4.0f;
    public float health = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            this.transform.position += Vector3.up * speed * Time.deltaTime;
            //transform.position = new Vector3(transform.position.x, transform.position.y + speed*Time.deltaTime, transform.position.z);
        }
        if(Input.GetKey(KeyCode.S)){
            this.transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A)){
            this.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D)){
            this.transform.position += Vector3.right * speed * Time.deltaTime;
        }
    }

    public void Teleport(Vector3 newPosition){
        this.transform.position = newPosition;
    }

    public void LoseHealth(float healthToLose){
        health -= 10;
    }
}
