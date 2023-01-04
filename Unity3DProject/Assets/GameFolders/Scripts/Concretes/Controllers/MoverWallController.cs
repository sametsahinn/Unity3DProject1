using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverWallController : WallController
{
    private const float FULL_CIRCLE = Mathf.PI * 2f;

    private Vector3 startPosition;

    [SerializeField] Vector3 direction;

    // [Range(0f, 1f)]
    [SerializeField] float factor;
    [SerializeField] float speed = 1f;

    private void Awake()
    {
        startPosition = transform.position;        
    }

    private void Update()
    {
        float cycle = Time.time / speed;
        //Debug.Log(Time.time);
        float sinWave = Mathf.Sin(cycle * FULL_CIRCLE);
        // Debug.Log(sinWave);

        factor = Mathf.Abs(sinWave);

        Vector3 offset = direction * factor;
        transform.position = offset + startPosition;

    }
}
