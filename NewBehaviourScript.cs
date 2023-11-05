using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // здоровье
    public int health = 5;
    // уровень
    public int level = 3;
    // скорость
    public int speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        // здоровье в игре
        health += level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
	transform.position = newPosition;
    }
}
