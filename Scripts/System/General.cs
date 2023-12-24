using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class General : MonoBehaviour
{
    public int NPCCount=0;
  [SerializeField] protected int nextLocationIndex;
   
   public void AddNPC()
    {
        NPCCount++;
    }
    public void CheckNPS()
    {
        NPCCount--;
        if (NPCCount < 1)
        {
            SceneManager.LoadScene(nextLocationIndex);
        }
    }

   

}
