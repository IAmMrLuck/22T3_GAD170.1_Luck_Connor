using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// FINISHED - 15/11/22
namespace ConnorLuck
{
    /// <summary>
    /// This class holds functionality for scene transition and reloading this scene to restart the game.
    /// </summary>
    public class SceneLoader : MonoBehaviour
    {
        // TODO Loader 1/4: Declare a string variable for the name of the scene we want to load, which is this scene. (Write in the scene's name in Unity's Inspector.)

        public static SceneLoader Instance;

        private void Awake()

        {
            if (Instance == null)
            {
                Instance = this;
            }

            else if (Instance != this)

            {
                Destroy(gameObject);
            }

        }

        public void sceneToMoveTo()

        {
            SceneManager.LoadScene("Platformer (The Pipeworks)");

        }

        


            // TODO Loader Final: Add code comments describing what you hope your code is doing throughout this script.

            // TODO Loader Bonus 1: Modify your load scene method so that you can write any string or int level and it will load that. (Hint: Adding parameters to it might help!)

            // TODO Loader Bonus 2: Add a reference to your second scene (or any scenes you want) so that a second (or more) level can be loaded!

        
    }
}
