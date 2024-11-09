using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public abstract class PowerUp : MonoBehaviour
{
    public abstract void ApplyPowerUp(Player player);
}
