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


    bool canMove;
    bool isForceUp;
    float leftRight;

    public float TurnSpeed => _turnSpeed;
    public float Force => _force;

    public bool CanMove => canMove;


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
        canMove = true;
    }

    private void OnEnable()
    {
        GameManager.Instance.OnGameOver += HandleOnEventTriggered;
        GameManager.Instance.OnMissionSucced += HandleOnEventTriggered;
    }


    private void OnDisable()
    {
        GameManager.Instance.OnGameOver -= HandleOnEventTriggered;
        GameManager.Instance.OnMissionSucced -= HandleOnEventTriggered;
    }

    /// <summary>
    /// Input
    /// </summary>
    void Update()
    {
        // Debug.Log(_input.IsForceUp);

        if (!canMove)
        {
            return;
        }

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

    private void HandleOnEventTriggered()
    {
        canMove = false;
        isForceUp = false;
        leftRight = 0f;
        fl.FuelIncrease(0.0f);
    }
}
