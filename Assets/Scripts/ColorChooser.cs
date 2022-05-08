using Es.InkPainter;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColorChooser : MonoBehaviour
{
    public Animator f;
    public static ColorChooser i;
    public static Color col;
    public Color Col;
    public Slider sl;
    public Slider sliderForWater;
    public Texture a;

    public Texture[] shapes;
    // Start is called before the first frame update
    void Start()
    {
        i = this;
    }

    // Update is called once per frame
    void Update()
    {
        Col = col;
    }
    public void BrushColor(Image im)
    {
        col = im.color;
    }
    public void ShapeChanger(int num)
    {
        a = shapes[num];
    }
    public void NextFlip()
    {
        f.SetTrigger("On");
    }
    public void Resett()
    {
        SceneManager.LoadScene("Main");
    }
}
