using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinputShot : CShot
{
    // Update is called once per frame
    protected override void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetMouseButton(0))
        {
            Shot();
        }
    }
}
