﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroDePegasusSkill: Skill
{
    string name = "Meteoro de Pegasus";

    public override void DoAction()
    {
        Debug.Log(this.name);
    }
}