using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

namespace ConnorLuck
{
    /// <summary>
    /// This class holds all the logic for our levelling system, so that includes logic to handle levelling up, gaining XP and detecting when we should level up.
    /// </summary>
    public class LevellingSystem : MonoBehaviour
    {
        [SerializeField] private float currentXp;
        [SerializeField] private float currentLevel;
        [SerializeField] private float levelThreshhold;

        private void Start()
        {
            currentLevel = 1f;
            currentXp = 0f;
            levelThreshhold = currentLevel * 100;
            Debug.Log("My current level is " + currentLevel + ".");
            Debug.Log("I have " + currentXp + "XP.");
            Debug.Log(levelThreshhold + " 'till next level.");
            currentXp = Random.Range(90, 118);
            Debug.Log("I have " + currentXp + " XP.");
            
            if (currentLevel > levelThreshhold)
            {
                currentLevel++;
                Debug.Log("" + currentLevel);
            }
            
            Debug.Log("My current level is " + currentLevel + ".");
            Debug.Log(levelThreshhold + " 'till next level."); 
            // TODO XP Final: Add code comments describing what you hope your code is doing throughout this script.

            // TODO XP Bonus: Adjust our character's stats ("runSpeed" and/or "jumpStrength") based on their level. (Hint: You'll need a reference to the SimpleCharacterController script!)

        }
    }
}
