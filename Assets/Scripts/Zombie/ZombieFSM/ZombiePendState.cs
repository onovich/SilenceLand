﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiePendState : FSMState
{

    public ZombiePendState(FSMSystem fsm) : base(fsm)
    {
        stateID = StateID.Pend;
       




    }

    public override void Act(GameObject enemy)
    {
        enemy.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);
        //enemy.GetComponent<Zombie>().Stop();
        enemy.GetComponent<ZombieEntity>().Stop();



    }

    public override void Reason(GameObject enemy)
    {
        /*
        //凡见则追
        if (enemy.GetComponent<Zombie>().SeePlayer)
        {
            fsm.PerformTransition(Transition.SeePlayer);
        }
        //仅闻未见则寻
        if ((!enemy.GetComponent<Zombie>().SeePlayer) && (enemy.GetComponent<Zombie>().hearAnything))
        {
            fsm.PerformTransition(Transition.Hear);
        }
         */
        if (enemy.GetComponent<ZombieEntity>().SeeTarget() != null)
        {
            fsm.PerformTransition(Transition.SeePlayer);

        }
        if (enemy.GetComponent<ZombieEntity>().Hear() && enemy.GetComponent<ZombieEntity>().SeeTarget() == null)
        {
            fsm.PerformTransition(Transition.Hear);

        }
    }
}
