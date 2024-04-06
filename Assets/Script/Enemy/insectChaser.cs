using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class insectChaser : MonoBehaviour
{
    public GameObject target;
    public float speed = 10;

    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Tirador");
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, target.transform.position);
        Vector2 direction = target.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        transform.position = Vector2.MoveTowards(this.transform.position, target.transform.position, speed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    }
}
