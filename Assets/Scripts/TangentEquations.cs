using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TangentEquations : MonoBehaviour
{
    protected Vector3 GetRotatedTangent(float degree, float scale)
    {
        double angle = degree * Mathf.Deg2Rad;

        float x = scale * (float)Math.Sin(angle);
        float z = scale * (float)Math.Cos(angle);

        return new Vector3(x, 0, z);

    }

}
