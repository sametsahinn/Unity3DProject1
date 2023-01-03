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
    private Fuel fl;


    bool isForceUp;
    float leftRight;

    public float TurnSpeed => _turnSpeed;
    public float Force => _force;



    private void Awake()
    { 
        _input = new DefaultInput();

        mvr = new Mover(this);
        rtr = new Rotator(this);
        fl = GetComponent<Fuel>();
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

        if (_input.IsForceUp && !fl.IsEmpty)
        {
            isForceUp = true;
        } 
        else 
        { 
            isForceUp = false;
            fl.FuelIncrease(0.01f);
        }

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
            fl.FuelDecrease(0.2f);
        }

        rtr.FixedTick(leftRight);
        
        
    }
}
