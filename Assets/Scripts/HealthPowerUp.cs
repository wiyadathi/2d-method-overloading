using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : PowerUp
{
    public int healthIncrease = 50;

    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(healthIncrease);
    }
}
