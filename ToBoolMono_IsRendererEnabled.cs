using UnityEngine;

public class ToBoolMono_IsRendererEnabled : AbstractToBooleanMono
{
    public Renderer m_renderer;
    public bool m_inverse = false;

    public override bool CheckCondition()
    {
        if (m_inverse)
        {
            return !m_renderer.enabled;
        }
        return m_renderer.enabled;
    }
}
