using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator animator;
    private Transform transform;

    [Range(0, 0.999f)]
    public float[] fingers = { 0, 0, 0, 0, 0 };

    [Range(0, 360)]
    public float yaw = 0.0f;
    [Range(0, 360)]
    public float roll = 0.0f;
    [Range(0, 360)]
    public float pitch = 0.0f;

    void Start()
    {
        animator = GetComponent<Animator>();
        transform = GameObject.FindGameObjectWithTag("rotationpoint").GetComponent<Transform>();
    }

    void Update()
    {
        Change(fingers);
    }

    void Change(float[] fingers)
    {
        for (int i = 0; i < 5; i++)
        {
            animator.SetFloat("F"+i, fingers[i]);
        }

        transform.eulerAngles = new Vector3(roll,pitch,yaw);
    }
}
