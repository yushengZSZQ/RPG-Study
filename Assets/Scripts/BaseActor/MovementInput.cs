using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInput : MonoBehaviour
{
    #region System Function
    private void Update()
    {
        SetPlayerAnimMovePam();
    }
    #endregion

    #region Player Animation Controller
    public Animator animator;
    public CharacterController character;
    public float MoveSpeed;
    public UI_JoyStick joyStick;
    float horizontal;
    float vertical;
    float speed;
    float s1;
    float s2;
    private void SetPlayerAnimMovePam()
    {

#if UNITY_EDITOR
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        s1 = Mathf.Sqrt(horizontal * horizontal + vertical * vertical);
        s2 = null != joyStick ? joyStick.Dir.magnitude : 0;
        speed = s1 > s2 ? s1 : s2;
        if (s2 > s1)
        {
            horizontal = joyStick.Dir.x;
            vertical = joyStick.Dir.y;
        }
#else
        speed = joyStick.Dir.magnitude;
#endif

        animator.SetFloat("IdleAndRun", speed);

        if (speed > 0.01f)
        {
            PlayerCtrlMovement(horizontal, vertical);
        }


    }

    void PlayerCtrlMovement(float x,float z)
    {
        var dir = x * Vector3.right + z * Vector3.forward;
        transform.forward = dir;
        character.Move(MoveSpeed * Time.deltaTime * dir);
    }
    #endregion
}
