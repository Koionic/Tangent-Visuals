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
    /// <param name="radius">The radius of the initial circle in units</param>
    /// <returns></returns>
    protected Vector3 GetRotatedTangent(float degree, float radius)
    {
        //converting the angle from degrees into radians
        double angle = degree * Mathf.Deg2Rad;

        float x = radius * (float)Math.Sin(angle);
        float z = radius * (float)Math.Cos(angle);

        return new Vector3(x, 0, z);
    }


    //      RADIUS EQUATION FOR TANGENT CIRCLE
    //                (0 is theta)
    //
    //            a^2 - b^2 + d^2 - 2ad0
    //       r = ========================
    //                2(a ± b - d0)
    //
    //     a = Radius of Outer Circle
    //     b = Radius of of Inner Circle
    //     c = Centre Point of Outer Circle's Tangent
    //     d = Distance between A and B;

    protected Vector4 FindTangentCircleBetweenTwoCircles(Vector4 A, Vector4 B, float degree)
    {
        //the point on the tangent of the outer circle
        Vector3 C = GetRotatedTangent(degree, A.w);

        float AB = Vector3.Distance(CentrePositionOf(A), CentrePositionOf(B));
        //makes sure AB doesn't equal 0
        AB = Mathf.Max(AB, 0.1f);

        float AC = Vector3.Distance(CentrePositionOf(A), C);
        float BC = Vector3.Distance(CentrePositionOf(B), C);

        //the angle between the centre of tangent circle and the centre of the outer circle, originating at the centre of the inner circle
        float angleCAB = ((AC * AC) + (AB * AB) - (BC * BC)) / (2 * AC * AB);

        //the radius of the tangent circle
        float r = (((A.w * A.w) - (B.w * B.w) + (AB * AB)) - (2 * A.w * AB * angleCAB))
                            / (2 * (A.w + B.w - AB * angleCAB));

        //does the final position of the tanget circle between outer and inner circle
        C = GetRotatedTangent(degree, A.w - r);

        return new Vector4(C.x, C.y, C.z, r);
    }

    protected Vector3 CentrePositionOf(Vector4 stats)
    {
        return new Vector3(stats.x, stats.y, stats.z);
    }

    protected Vector3 ScaleOf(Vector4 stats)
    {
        return RadiusOf(stats) * 2;
    }

    protected Vector3 RadiusOf(Vector4 stats)
    {
        return new Vector3(stats.w, stats.w, stats.w);
    }

}
