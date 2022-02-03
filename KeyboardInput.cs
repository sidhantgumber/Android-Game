using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : InputSystem
{
    public override InputModule CurrentModule { get; protected set; }

    public override void OnActionButton(ActionButton actionButton)
    {
        
    }

    public override void OnLeftKey()
    {
    
    }

    public override void OnRightKey()
    {
  
    }

    public override void RegisterForInput(InputModule module)
    {
      
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A)) OnLeftKey();
        else if (Input.GetKey(KeyCode.D)) OnRightKey();

        if (Input.GetKeyDown(KeyCode.Space)) OnActionButton(ActionButton.JUMP);
        else if (Input.GetKeyDown(KeyCode.C)) OnActionButton(ActionButton.CROUCH);
        else if (Input.GetKeyDown(KeyCode.LeftControl)) OnActionButton(ActionButton.SHOOT);

    }
}
