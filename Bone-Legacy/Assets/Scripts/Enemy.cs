using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private int _health;
    private int _damage;
    private int _range;
    private int _enemy_position_x;
    private int _enemy_position_y;

    // Start is called before the first frame update
    void Start()
    {
        _health = 100;
        _damage = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (_health <= 0)
        {
            //despawn enemy
        }

        if (_enemy_position_x <= _range && _enemy_position_y <= _range)
        {
            //attack enemy
        }
    }
}
