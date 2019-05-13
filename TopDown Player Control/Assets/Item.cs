using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public float decaytime;
    private float birthTime;
    // Start is called before the first frame update
    void Start()
    {
        birthTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (decaytime != 99)
        {

        }
    }

    public void onPickUp()
    {
        Destroy(this.gameObject);
    }
    
}
