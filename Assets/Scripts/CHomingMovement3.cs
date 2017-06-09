using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHomingMovement3 : CHomingMovement {
    int countHoming = 500;
    protected override void Update()
    {
        if (countHoming > 0)
        {
            Invoke("Homing", _delay);
        }
        countHoming--;
        base.Update();
    }
}
