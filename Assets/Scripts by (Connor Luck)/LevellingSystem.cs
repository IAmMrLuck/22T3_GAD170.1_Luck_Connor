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
        // these are my variables

        private void Start()
        {
            currentLevel = 1f;
            currentXp = 0f;
            levelThreshhold = currentLevel * 100;
            // these are the values i have stored within my variables

            Debug.Log("My current level is " + currentLevel + ".");
            Debug.Log("I have " + currentXp + "XP.");
            Debug.Log(levelThreshhold + " 'till next level.");
            // the debug function allows what i write next to be displayed in the console
            // it's a great way to check that what i've added is working

            currentXp = Random.Range(50, 100);
            // this generates a random number, between 50 and 100

            Debug.Log("I have " + currentXp + " XP.");
            // more debug to be displayed in the console
            
            if (currentLevel > levelThreshhold)
            {
                currentLevel++;
                Debug.Log("" + currentLevel);
            }
            // this will increase the player level by 1 when they have met the level threshold

            Debug.Log("My current level is " + currentLevel + ".");
            Debug.Log(levelThreshhold + " 'till next level."); 
            // even more debugging


            // TODO XP Final: Add code comments describing what you hope your code is doing throughout this script.

            // TODO XP Bonus: Adjust our character's stats ("runSpeed" and/or "jumpStrength") based on their level. (Hint: You'll need a reference to the SimpleCharacterController script!)

        }
    }
}
