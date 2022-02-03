using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class InputSystem
{
    public abstract InputModule CurrentModule { get; protected set; }
    public abstract void RegisterForInput(InputModule module);
    public abstract void OnLeftKey();
    public abstract void OnRightKey();
    public abstract void OnActionButton(ActionButton actionButton);


}
    public enum ActionButton
    {
        JUMP,
        CROUCH,
        SHOOT
    }