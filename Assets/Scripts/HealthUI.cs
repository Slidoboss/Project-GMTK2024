using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    private HealthSystem _healthSystem;
    private readonly PlayerStat _playerStat = new PlayerStat();
    private Slider _healthBar;

    void Awake()
    {
        _healthSystem = new HealthSystem(_playerStat.playerHealth);
        _healthBar = GetComponent<Slider>();
    }
    void Update()
    {
        _healthBar.value = _healthSystem.GetHealth;
        Debug.Log(_healthSystem.GetHealth);
        if(Input.GetKeyDown(KeyCode.L))
        {
            _healthSystem.Damage(10);
        }
    }

}
