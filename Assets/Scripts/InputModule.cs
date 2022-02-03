using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface InputModule 
{
    void OnLeftKey();
     void OnRightKey();
     void OnActionButton(ActionButton button);

}
