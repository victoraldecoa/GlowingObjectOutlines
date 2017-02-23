using UnityEngine;

public class MouseGlowActivator : MonoBehaviour
{
    GlowObject _glow;

    void Awake()
    {
        _glow = GetComponent<GlowObject>();
    }

    void OnMouseEnter()
    {
        _glow.Activate();
    }

    void OnMouseExit()
    {
        _glow.Deactivate();
    }
}