using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class Jabba : MonoBehaviour
{
    public Text Score; // Reference to the UI text component that displays the counter value
    private int counter = 0; // The counter variable that keeps track of the number of points

    // This method is called when the button is clicked
    public void AddPoint()
    {
        counter++; // Increment the counter
        Score.text = "Points: " + counter; // Update the text component to display the new counter value
    }
}


