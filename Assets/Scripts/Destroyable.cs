using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour, IDamage
{
    public void TakeDamage()
    {
        Destroy(this);
    }
}
