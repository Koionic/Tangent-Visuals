using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TangentEquations : MonoBehaviour
{
    /// <summary>
    /// Returns the position of the tangent on the circle
    /// </summary>
    /// <param name="degree">The angle from the centre of the intial circle in degrees</param>
    /// <param name="scale">The radius of the initial circle in units</param>
    /// <returns></returns>
    protected Vector3 GetRotatedTangent(float degree, float scale)
    {
        //converting the angle from degrees into radians
        double angle = degree * Mathf.Deg2Rad;

        float x = scale * (float)Math.Sin(angle);
        float z = scale * (float)Math.Cos(angle);

        return new Vector3(x, 0, z);
    }

}
