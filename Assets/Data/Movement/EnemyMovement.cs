using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : Movement
{
    protected override void prefabMovement()
    {
        this.direction = Vector3.left;
        base.prefabMovement();
    }
}
