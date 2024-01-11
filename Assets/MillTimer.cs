using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MillTimer : MonoBehaviour
{
    private HingeJoint _currentJoint;
    private JointLimits _limits;

    public float _nextLimit = 90f;

    private float _previousLimit = 0f;
    private float _currentLimit = 0f;
    private float _timeLeft = 0f;

    void Start()
    {
        _currentJoint = GetComponent<HingeJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        _timeLeft += Time.deltaTime;
        if (_timeLeft > 1)
        {
            _timeLeft = 0f;

            _limits.max = _currentLimit;

            _currentJoint.limits = _limits;

            _previousLimit = _currentLimit;
            _currentLimit = _nextLimit;
            _nextLimit = _previousLimit;

        }
    }
}
