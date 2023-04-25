using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    public float timeStart = 60f;
    public float tracker = 55;
    public Text textBox;


    // Start is called before the first frame update
    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        timeStart -= Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();
    }

    void Every5SecLoseHealth(Time time){
        if(timeStart == tracker){
            tracker -= 5f;
            gameObject.SendMessage("LoseHealth", 10); 
        }
    }
}
