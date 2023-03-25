using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamage
{
    public int health;
    public int damage;

    public void TakeDamage()
    {
        health -= damage;
    }
}
