using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_JoyStick : MonoBehaviour
{
    public CommonJoyBtn commonBtn;
    public Vector3 Dir => (commonBtn.Dir);
}
