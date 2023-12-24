
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneLoader : MonoBehaviour
{
    [SerializeField] protected int sceneID;
   public void LoadScene()
    {
        SceneManager.LoadScene(sceneID);
    }
}
