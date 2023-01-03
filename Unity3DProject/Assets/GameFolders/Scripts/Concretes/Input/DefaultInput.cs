using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultInput
{

    private DefaltAction _input;

    public bool IsForceUp { get; set; }

    public float LeftRight { get; set; }


    public DefaultInput()
    {
        _input = new DefaltAction();

        _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();
        _input.Rocket.LeftRight.performed += context => LeftRight = context.ReadValue<float>();

        _input.Enable();
    }

   
}
