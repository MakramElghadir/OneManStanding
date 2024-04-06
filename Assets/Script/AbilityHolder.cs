using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityHolder : MonoBehaviour
{
    [SerializeField] List<BaseAbility> abilities;
    int selectedAbilityIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // si pulso 1
        // la seleccionada es la número 0

        if (Input.GetKeyDown("1"))
        {
            print("Normal gon selected");
            selectedAbilityIndex = 0;
        }

        if (Input.GetKeyDown("2"))
        {
            print("RATATA selected");
            selectedAbilityIndex = 1;
        }

        if (Input.GetKeyDown("3"))
        {
            print("Normal gon selected");
            selectedAbilityIndex = 2;
        }

        // si pulso 2
        // la seleccionada es la número 1

        // etc

        if (Input.GetMouseButtonDown(0)) {
            abilities[selectedAbilityIndex].Trigger();
        }
    }
}
