using System;
using System.Linq;
using UnityEngine;

public class EventBroker
{
    #region ProjectileOutOfBounds
    public static event Action ProjectileOutOfBounds;
    
    public static void CallProjectileOutOfBounds()
    {
        ProjectileOutOfBounds?.Invoke();
    }
    #endregion

    #region LifeLost
    public static event Action<int> LifeLost;

    public static void CallLifeLost(int lives)
    {
        LifeLost?.Invoke(lives);
    }
    #endregion

    #region ScoreUpdateOnKill
    public static event Action<int> ScoreUpdateOnKill;

    public static void CallScoreUpdateOnKill(int totalPoints)
    {
        ScoreUpdateOnKill?.Invoke(totalPoints);
    }
    #endregion

    #region EnemyDestroyed
    public static event Action<int> EnemyDestroyed;

    public static void CallEnemyDestroyed(int pointValue)
    {
        EnemyDestroyed?.Invoke(pointValue);
    }
    #endregion

    #region HitByEnemy
    public static event Action HitByEnemy;

    public static void CallHitByEnemy()
    {
        HitByEnemy?.Invoke();
    }
    #endregion

    #region EndGame
    public static event Action EndGame;

    public static void CallEndGame()
    {
        EndGame?.Invoke();
    }
    #endregion
}
