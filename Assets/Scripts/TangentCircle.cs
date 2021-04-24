using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TangentCircle : TangentEquations
{
    public GameObject circlePrefab;
    private GameObject innerCircleObj, outerCircleObj, tangentCircleObj;

    public Vector4 innerCircleStats, outerCircleStats;

    public float tangentRadius;
    public float tangentDegree;

    // Start is called before the first frame update
    void Start()
    {
        innerCircleObj = SpawnCircle(innerCircleStats);
        outerCircleObj = SpawnCircle(outerCircleStats);
        tangentCircleObj = SpawnCircle(outerCircleStats);
    }

    // Update is called once per frame
    void Update()
    {
        SetCircleStats(ref innerCircleObj, innerCircleStats);
        SetCircleStats(ref outerCircleObj, outerCircleStats);
        SetTangentStats(ref tangentCircleObj, tangentDegree);
    }

    GameObject SpawnCircle(Vector4 circleStats)
    {
        GameObject newCircle = Instantiate(circlePrefab);

        SetCircleStats(ref newCircle, circleStats);

        return newCircle;
    }

    GameObject SpawnTangentCircle(float radius, float degree)
    {
        GameObject newTangentObj = Instantiate(circlePrefab);

        SetTangentStats(ref newTangentObj, degree);

        return newTangentObj;
    }

    void SetCircleStats(ref GameObject circle, Vector4 stats)
    {
        circle.transform.position = new Vector3(stats.x, stats.y, stats.z);
        circle.transform.localScale = new Vector3(stats.w, stats.w, stats.w) * 2;
    }

    void SetTangentStats(ref GameObject circle, float degree)
    {
        circle.transform.position = GetRotatedTangent(degree, outerCircleStats.w) + outerCircleObj.transform.position;
        circle.transform.localScale = new Vector3(tangentRadius, tangentRadius, tangentRadius) * 2;
    }
}
