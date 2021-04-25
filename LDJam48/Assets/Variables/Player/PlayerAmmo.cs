using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerAmmo : ScriptableObject
{
    public int gunDamage;
    public float gunROF;
    public float meleeRate;
    public float gunRange;
    public int maximumAmmo;
    public int currentAmmo;
}
