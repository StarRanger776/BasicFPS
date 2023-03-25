using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappearing : MonoBehaviour, IDamage
{
    public GameObject other;
    public void TakeDamage()
    {
        gameObject.SetActive(false);
        other.SetActive(true);
    }
}
