using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangentCircle : TangentEquations
{
    public GameObject circlePrefab;
    GameObject innerCircleObj, outerCircleObj;

    public Vector4 innerCircleStats = new Vector4(), outerCircleStats = new Vector4();

    List<Vector4> tangentCircleStats = new List<Vector4>();
    List<GameObject> tangentCircleObjs = new List<GameObject>();

    [Range(1,64)]
    public int tangentCircleAmount;

    int prevCircleCount;

    public Move gamepadInput;

    Vector2 leftJoy, smoothLeftJoy;

    [Range(0f, 0.05f)]
    public float joystickSmoothAmount;

    [Range(0, 1)]
    public float distToOuterTangent;

    float radiusChange;

    [Range(0.1f, 10)]
    public float radiusChangeSpeed;

    // Start is called before the first frame update
    void Start()
    {
        innerCircleObj = SpawnCircle(innerCircleStats);
        outerCircleObj = SpawnCircle(outerCircleStats);

        SpawnTangentCircles();

        prevCircleCount = tangentCircleAmount;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerInput();

        SetCircleStats(innerCircleObj, innerCircleStats);
        SetCircleStats(outerCircleObj, outerCircleStats);

        if (tangentCircleAmount != prevCircleCount)
        {
            ClearTangentCircles();

            SpawnTangentCircles();

            prevCircleCount = tangentCircleAmount;
        }

        for (int i = 0; i < tangentCircleAmount; i++)
        {
            UpdateTangentStat(i);
            SetCircleStats(tangentCircleObjs[i], tangentCircleStats[i]);
        }
    }

    void PlayerInput()
    {
        leftJoy = gamepadInput.LeftJoystick;

        radiusChange = gamepadInput.TriggersInput;

        smoothLeftJoy = new Vector2(smoothLeftJoy.x * (1 - joystickSmoothAmount) + leftJoy.x * joystickSmoothAmount,
                                    smoothLeftJoy.y * (1 - joystickSmoothAmount) + leftJoy.y * joystickSmoothAmount);

        innerCircleStats = new Vector4(
                               (smoothLeftJoy.x * (outerCircleStats.w - innerCircleStats.w) * (1 - distToOuterTangent)) + outerCircleStats.x,
                               0.0f,
                               (smoothLeftJoy.y * (outerCircleStats.w - innerCircleStats.w) * (1 - distToOuterTangent)) + outerCircleStats.z,
                               innerCircleStats.w + (radiusChange * Time.deltaTime * radiusChangeSpeed));

        innerCircleStats.w = Mathf.Clamp(innerCircleStats.w, -outerCircleStats.w * (1 - distToOuterTangent), outerCircleStats.w * (1 - distToOuterTangent));
    }

    void SpawnTangentCircles()
    {
        ClearTangentCircles();

        for (int i = 0; i < tangentCircleAmount; i++)
        {
            tangentCircleObjs.Add(SpawnTangentCircle(i));
        }
    }

    void ClearTangentCircles()
    {
        if (tangentCircleObjs.Count > 0)
        {
            foreach (GameObject oldTangentCircle in tangentCircleObjs)
            {
                Destroy(oldTangentCircle);
            }

            tangentCircleObjs.Clear();
            tangentCircleStats.Clear();

            tangentCircleObjs = new List<GameObject>();
        }
    }

    GameObject SpawnCircle(Vector4 circleStats)
    {
        GameObject newCircle = Instantiate(circlePrefab, transform);

        SetCircleStats(newCircle, circleStats);

        return newCircle;
    }

    /// <summary>
    /// Updates the position and scale of the circle given
    /// </summary>
    /// <param name="circle">GameObject to be updated</param>
    /// <param name="stats">Position held in xyz, radius of circle held in w</param>
    void SetCircleStats(GameObject circle, Vector4 stats)
    {
        circle.transform.position = CentrePositionOf(stats) + transform.position;
        circle.transform.localScale = ScaleOf(stats);
    }

    GameObject SpawnTangentCircle(int iteration)
    {
        tangentCircleStats.Add(FindTangentStat(iteration));
        return SpawnCircle(tangentCircleStats[iteration]);
    }

    Vector4 FindTangentStat(int iteration)
    {
        return FindTangentCircleBetweenTwoCircles(outerCircleStats, innerCircleStats, (360f / tangentCircleAmount) * iteration);
    }

    void UpdateTangentStat(int iteration)
    {
        tangentCircleStats[iteration] = FindTangentStat(iteration);
    }
}
