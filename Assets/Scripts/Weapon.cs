﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon:MonoBehaviour
{
    public virtual void Attack() { }
    public virtual float AttackPower { get; set; }

}
