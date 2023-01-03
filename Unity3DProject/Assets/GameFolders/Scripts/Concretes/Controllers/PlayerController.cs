using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float _force = 55;

    [SerializeField] float _turnSpeed = 30f;

    // Rigidbody rigidBdy;

    DefaultInput _input;

    private Mover mvr;
    private Rotator rtr;

    bool isForceUp;
    float leftRight;

    public float TurnSpeed => _turnSpeed;
    public float Force => _force;



    private void Awake()
    { 
        _input = new DefaultInput();

        mvr = new Mover(this);
        rtr = new Rotator(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    /// <summary>
    /// Input
    /// </summary>
    void Update()
    {
        // Debug.Log(_input.IsForceUp);

        if (_input.IsForceUp)
        {
            isForceUp = true;
        } 
        else { isForceUp = false; }

        leftRight = _input.LeftRight;
    }

    /// <summary>
    /// Fizik iþlemleri
    /// </summary>
    private void FixedUpdate()
    {
        if (isForceUp)
        {
            // rigidBdy.AddForce(Vector3.up * Time.deltaTime * _force);

            mvr.FixedTick();
        }

        rtr.FixedTick(leftRight);
        
        
    }
}
