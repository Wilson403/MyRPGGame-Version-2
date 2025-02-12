﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using M_CharactorSystem;

namespace AIMgr.CharactorAIMgr
{
    public class EnemyAI : ICharactorAI
    {
        public override void ChangeAiState(IAIState state)
        {
            base.ChangeAiState(state);
            state.SetAttackPosition(AttackPostion);
        }

        //检测是否进入了进攻范围
        public override bool TargetRange(ICharactor theNearTarget,int range)
        {
            float targetdist;
            targetdist = Vector3.Distance(TheTarget.transform.position, theNearTarget.transform.position);
            if (targetdist <= range)
            {
                return true;
            }

            return false;
        }
    }
}

