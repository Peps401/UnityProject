using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomController : MonoBehaviour
{
    public bool initialVisibility = false;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(initialVisibility);
    }

    public void Toggle(bool visible){
        gameObject.SetActive(visible);
    }
}
