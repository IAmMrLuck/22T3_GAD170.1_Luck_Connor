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
        // TODO XP 1/13 Declare a new variable to track the current amount of XP we have accumulated (our current XP).
        [SerializeField] private float currentXp;
        // TODO XP 2/13 Declare a new variable to track our current Level.
        [SerializeField] private float currentLevel;
        // TODO XP 3/13 Declare a new variable to track the amount of XP required to level-up (our current Level Up Threshold).
        [SerializeField] private float levelThreshhold;

        private void Start()
        {
            // TODO XP 4/13: Set our current level to one.
            currentLevel = 1f;
            // TODO XP 5/13: Set our current XP to zero.
            currentXp = 0f;
            // TODO XP 6/13: Set our current XP Threshold to be our level multiplied by our 100.
            levelThreshhold = currentLevel * 100;
            // TODO XP 7/13: Debug out our starting values of our level, XP and current XP threshold.
            Debug.Log("My current level is " + currentLevel + ".");
            Debug.Log("I have " + currentXp + "XP.");
            Debug.Log(levelThreshhold + " 'till next level.");
            // TODO XP 8/13: Increase the current XP by a random amount between 50 and 100.
            currentXp = Random.Range(90, 118);
            // TODO XP 9/13: Debug out our current XP.
            Debug.Log("I have " + currentXp + " XP.");
            // TODO XP 10/13: Check if our current XP is more than our threshold.
            
            if (currentLevel > levelThreshhold)
            // TODO XP 11/13: If it is, then let's increase out level by one.
            {
                currentLevel++;
                Debug.Log("" + currentLevel);
            }
            // TODO XP 12/13: Let's also increase recalculate our current XP threshold as we've levelled up.
            Debug.Log(levelThreshhold + " 'till next level.");
            // TODO XP 13/13: Debug out our new level value, as well as our current XP and the next threshold we need to hit.

            // TODO XP Final: Add code comments describing what you hope your code is doing throughout this script.

            // TODO XP Bonus: Adjust our character's stats ("runSpeed" and/or "jumpStrength") based on their level. (Hint: You'll need a reference to the SimpleCharacterController script!)

        }
    }
}
