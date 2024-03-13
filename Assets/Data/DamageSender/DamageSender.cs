using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSender : HungMonobehavior
{
    [SerializeField] protected int damage = 1;
    public virtual void SendObj(Transform obj)
    {
        DamageReceiver damageReceiver = obj.GetComponentInChildren<DamageReceiver>();
        if (damageReceiver == null) return;
        this.SendDamage(damageReceiver);
    }
    public virtual void SendDamage(DamageReceiver damageReceiver)
    {
        damageReceiver.Deduct(this.damage);
    }
}
