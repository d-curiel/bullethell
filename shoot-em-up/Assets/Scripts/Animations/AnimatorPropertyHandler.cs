using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimatorPropertyHandler : MonoBehaviour
{
    [SerializeField]
    private string _variableName;

    private Animator _a;

    private void Awake()
    {
        _a = GetComponent<Animator>();
    }

    public void SetValue(float value)
    {
        _a.SetFloat(_variableName, value);
    }
    public void SetValue(bool value)
    {
        _a.SetBool(_variableName, value);
    }
    public void SetValue(int value)
    {
        _a.SetInteger(_variableName, value);
    }

}
