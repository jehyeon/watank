using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTwice : Skill
{
    private Attack attack;
    // Start is called before the first frame update
    void Start()
    {
        attack = GetComponent<Attack> (); 
        active = false;
    }

    // Update is called once per frame

    public override void Activate()
    {
        active = true;
        attack.Twice = true;
        attack.ProjectilePrefab.Damage = 20f;
        attack.ProjectilePrefab.ExpScale /= 1.5f;
        Debug.Log("skill Activating");
    }

    public override void DeActivate () {
        active = false;
        attack.Twice = false;
        attack.ProjectilePrefab.Damage = 30f;
        attack.ProjectilePrefab.ExpScale = new Vector3 (4, 4, 4);
        Debug.Log("skill DeActivating");
    }
}
