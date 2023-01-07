using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;

    private void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var inputJump = Input.GetButtonDown("Jump");
        var inputJumpRelease = Input.GetButtonUp("Jump");

        if (horizontal != 0)
        {
            //var _currentHorizontalSpeed += horizontal * _moveSpeed * Time.deltaTime;

            //_currentHorizontalSpeed = Mathf.Clamp(_currentHorizontalSpeed, -_moveClamp, _moveClamp);

            //// Apply bonus at the apex of a jump
            //var apexBonus = Mathf.Sign(horizontal) * _apexBonus * _apexPoint;
            //_currentHorizontalSpeed += apexBonus * Time.deltaTime;
        }
    }
}
