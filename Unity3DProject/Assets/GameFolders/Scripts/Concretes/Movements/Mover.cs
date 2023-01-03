using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover 
{

    Rigidbody _rigidbody;
    PlayerController _playerController;


    public Mover(PlayerController playerController)
    {
        _playerController = playerController;
        _rigidbody = _playerController.GetComponent<Rigidbody>();
    }

    public void FixedTick()
    {
        _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * _playerController.Force);
    }

}
