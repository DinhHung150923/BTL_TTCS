using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HeroDamageReceiver : DamageReceiver
{
    [SerializeField] protected CharacterCtrl characterCtrl;
    protected override void LoadComponent()
    {
        base.LoadComponent();
        this.LoadCharacterCtrl();
    }
    protected virtual void LoadCharacterCtrl()
    {
        if (this.characterCtrl != null) return;
        this.characterCtrl = transform.parent.GetComponent<CharacterCtrl>();
        Debug.LogWarning(transform.name + "LoadCharacterCtrl :", gameObject);
    }
    protected override void SetHpmax()
    {
        this.hpmax = 15;
    }
    protected override void Ondead()
    {
        this.characterCtrl.ModelCtrl.Animator.SetBool("IsDying", true);
        //Invoke(nameof(this.DespawnEnemy), this.timeDieDelay);
        this.DespawnEnemy();
    }
    protected virtual void DespawnEnemy()
    {
        EnemySpawner.Instance.DeSpawn(transform.parent);
    }
}
