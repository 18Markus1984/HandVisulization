using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStarten : MonoBehaviour
{
    private Animator transform;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {

    }

    public void starten(Camera Camera1)
    {
        transform = Camera1.GetComponent<Animator>();
        transform.enabled = true;
        GetComponent<Canvas>().enabled = false;
    }
}
