using UnityEngine;

public class ToBoolMono_TwoPointsCloseEnough : AbstractToBooleanMono
{
    public Transform m_pointA;
    public Transform m_pointB;
    public float m_distanceThreshold = 0.1f;

    public override bool CheckCondition()
    {
        return Vector3.Distance(m_pointA.position, m_pointB.position) < m_distanceThreshold;
    }
}
