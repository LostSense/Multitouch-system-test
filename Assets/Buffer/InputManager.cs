using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using APITouch = UnityEngine.InputSystem;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public Text firstText;
    public Text secondText;
    private TouchSystem controller;

    private bool firstFingerTouch = false;
    private bool secondFingerTouch = false;
    private bool thirdFingerTouch = false;
    private Vector2 firstTouchPosition = Vector2.zero;
    private Vector2 secondTouchPosition = Vector2.zero;
    private Vector2 thirdTouchPosition = Vector2.zero;
    private Vector2 direction = Vector2.zero;
    private float deltaAngleDirection = 0f;
    private float radius = 0f;
    private float deltaRadius = 0f;

    // Start is called before the first frame update
    void Start()
    {
        controller = new TouchSystem();
        controller.Enable();
        SubscribeAllEvents();
    }

    private void SubscribeAllEvents()
    {
        controller.Player.TouchOnePhase.performed += arg => GetFirstTouchPhase(arg.ReadValue<APITouch.TouchPhase>());
        controller.Player.TouchOneDelta.performed += arg => GetFirstTouchDelta(arg.ReadValue<Vector2>());
        controller.Player.TouchOnePosition.performed += arg => GetFirstTouchPosition(arg.ReadValue<Vector2>());
        controller.Player.TouchOneStartPosition.performed += arg => GetFirstTouchStartPosition(arg.ReadValue<Vector2>());
        controller.Player.TouchTwoPhase.performed += arg => GetSecondTouchPhase(arg.ReadValue<APITouch.TouchPhase>());
        controller.Player.TouchTwoDelta.performed += arg => GetSecondTouchDelta(arg.ReadValue<Vector2>());
        controller.Player.TouchTwoPosition.performed += arg => GetSecondTouchPosition(arg.ReadValue<Vector2>());
        controller.Player.TouchTwoStartPosition.performed += arg => GetSecondTouchStartPosition(arg.ReadValue<Vector2>());
        controller.Player.TouchThreePhase.performed += arg => GetThirdTouchPhase(arg.ReadValue<APITouch.TouchPhase>());
        controller.Player.TouchThreeDelta.performed += arg => GetThirdTouchDelta(arg.ReadValue<Vector2>());
        controller.Player.TouchThreePosition.performed += arg => GetThirdTouchPosition(arg.ReadValue<Vector2>());
        controller.Player.TouchThreeStartPosition.performed += arg => GetThirdTouchStartPosition(arg.ReadValue<Vector2>());
        controller.Player.BackButtonPressed.performed += arg => Back();
    }

    // Update is called once per frame
    void Update()
    {
        if(firstFingerTouch && secondFingerTouch)
        {
            GetRadiusBetweenFingers();
            GetChangedAngleBetweenFingers();
        }
        else
        {
            ResetValues();
        }
    }

    private void ResetValues()
    {
        direction = Vector2.zero;
        deltaAngleDirection = 0f;
        radius = 0f;
        deltaRadius = 0f;
    }

    private void GetChangedAngleBetweenFingers()
    {
        Vector2 newDirection = (secondTouchPosition - firstTouchPosition).normalized;
        if(direction == Vector2.zero)
        {
            direction = newDirection;
        }
        deltaAngleDirection = Vector2.SignedAngle(direction, newDirection);
        direction = newDirection;
        secondText.text = deltaAngleDirection.ToString(); //remove this think
    }

    private void GetRadiusBetweenFingers()
    {
        float newRadius = (firstTouchPosition - secondTouchPosition).magnitude;
        deltaRadius = newRadius - radius;
        firstText.text = deltaRadius.ToString(); //removi this think
        radius = newRadius;
    }

    private void GetFirstTouchPhase(APITouch.TouchPhase phase)
    {
        firstFingerTouch = SetTouchState(phase, firstFingerTouch);
    }

    private bool SetTouchState(APITouch.TouchPhase phase, bool touchState)
    {
        if (phase == APITouch.TouchPhase.Began)
        {
            return true;
        }
        else if (phase == APITouch.TouchPhase.Ended)
        {
            return false;
        }

        return touchState;
    }

    private void GetFirstTouchDelta(Vector2 position)
    {
        //Delta from moving finger
    }

    private void GetFirstTouchPosition(Vector2 position)
    {
        firstTouchPosition = position;
    }

    private void GetFirstTouchStartPosition(Vector2 vector2)
    {
        //make some validation if need
    }

    private void GetSecondTouchPhase(APITouch.TouchPhase phase)
    {
        secondFingerTouch = SetTouchState(phase, secondFingerTouch);
    }

    private void GetSecondTouchPosition(Vector2 position)
    {
        secondTouchPosition = position;
    }

    private void GetSecondTouchDelta(Vector2 position)
    {
        //Delta from moving finger
    }

    private void GetSecondTouchStartPosition(Vector2 position)
    {
        //make some validation if need
    }

    private void GetThirdTouchPhase(APITouch.TouchPhase phase)
    {
         thirdFingerTouch = SetTouchState(phase, thirdFingerTouch);
    }

    private void GetThirdTouchPosition(Vector2 position)
    {
        thirdTouchPosition = position;
    }

    private void GetThirdTouchDelta(Vector2 position)
    {
        //Delta from moving finger
    }

    private void GetThirdTouchStartPosition(Vector2 position)
    {
        //make some validation if need
    }

    private void Back()
    {
        Application.Quit();
    }
}
