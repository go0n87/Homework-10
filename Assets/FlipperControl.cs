using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperControl : MonoBehaviour
{
    public float RestPosition = 0f;
    public float PressedPosition = -45f;
    public float HitStrenght = 10000f;
    public float FlipperDumper = 150f;
    
    private HingeJoint _objectHingeJoint;
    private JointSpring _spring;

    public KeyCode PushButton;

    void Start()
    {
        _objectHingeJoint = GetComponent<HingeJoint>();
        _objectHingeJoint.useSpring = true;
        _objectHingeJoint.useLimits = true;


    }

    void Update()
    {
        
        _spring.spring = HitStrenght;
        _spring.damper = FlipperDumper;

        if (Input.GetKey(PushButton))
        {
            _spring.targetPosition = PressedPosition;
        }
        else
        {
            _spring.targetPosition = RestPosition;
        }

        _objectHingeJoint.spring = _spring;
        
    }
}
