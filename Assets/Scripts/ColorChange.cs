using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour, IDamage
{
    public MeshRenderer meshRenderer;
    public Color color1;
    public Color color2;
    public void TakeDamage()
    {
        meshRenderer.material.color = color2;
    }
}
