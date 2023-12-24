using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MathHelper
{
    public static int VectorToDirectionIndex(Vector2 vector , int slice)
    {
        if(vector==Vector2.zero)
            return -1;

       vector.Normalize();

        float step = 360 / slice;

        float halfStep=step/2;

        float angle = Vector2.SignedAngle( vector, Vector2.up);

        angle += halfStep;

        if (angle < 0)
        {
            angle += 360;
        }

        float stepIndex = angle / step;

        return Mathf.FloorToInt(stepIndex);
    }
}
