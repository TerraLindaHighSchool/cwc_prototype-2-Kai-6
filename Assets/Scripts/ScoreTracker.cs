using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour
{
    private FileStream dataFileStream;
    private string dataFileName;
    public Text scoreBox;
    // Start is called before the first frame update
    void Start()
    {
        scoreBox = gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void WriteToScore()
    {
        using (dataFileStream = new FileStream(dataFileName, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        using (StreamWriter sw = new StreamWriter(dataFileStream))
            sw.WriteLine("Score, Name, Date");
    }
}
