using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CHomingMovement2 : CHomingMovement {
    protected override void Update()
    {
        Invoke("Homing", _delay);
        base.Update();
    }
}
