using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable<T>
{
    void Damage(T damage);
}

public interface IKillable
{
    void Kill();
}