using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ValoresDefecto : MonoBehaviour
{
   private float valor1;
    private float valor2;
    private float valor3;
    private float valor4;
    private float valor5;
    public GameObject buttoon;
    public GameObject KilVal1;
    public GameObject KilVal2;
    public GameObject KilVal3;
    public GameObject KilVal4;
    public GameObject KilVal5;
    public GameObject InputVal1;
    public GameObject InputVal2;
    public GameObject InputVal3;
    public GameObject InputVal4;
    public GameObject InputVal5;
    

      void Awake(){
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    { 
      LoadData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SaveData(){
      PlayerPrefs.SetFloat("valor1",float.Parse(InputVal1.GetComponent<TMP_InputField>().text));
      PlayerPrefs.SetFloat("valor2",float.Parse(InputVal2.GetComponent<TMP_InputField>().text));
      PlayerPrefs.SetFloat("valor3",float.Parse(InputVal3.GetComponent<TMP_InputField>().text));
      PlayerPrefs.SetFloat("valor4",float.Parse(InputVal4.GetComponent<TMP_InputField>().text));
      PlayerPrefs.SetFloat("valor5",float.Parse(InputVal5.GetComponent<TMP_InputField>().text));
      LoadData();

}

    public void LoadData(){
      KilVal1.GetComponent<TextMeshProUGUI>().text=""+PlayerPrefs.GetFloat("valor1",0);
      KilVal2.GetComponent<TextMeshProUGUI>().text=""+PlayerPrefs.GetFloat("valor2",0);
      KilVal3.GetComponent<TextMeshProUGUI>().text=""+PlayerPrefs.GetFloat("valor3",0);
      KilVal4.GetComponent<TextMeshProUGUI>().text=""+PlayerPrefs.GetFloat("valor4",0);
      KilVal5.GetComponent<TextMeshProUGUI>().text=""+PlayerPrefs.GetFloat("valor5",0);
      InputVal1.GetComponent<TMP_InputField>().text=""+PlayerPrefs.GetFloat("valor1",0);
      InputVal2.GetComponent<TMP_InputField>().text=""+PlayerPrefs.GetFloat("valor2",0);
      InputVal3.GetComponent<TMP_InputField>().text=""+PlayerPrefs.GetFloat("valor3",0);
      InputVal4.GetComponent<TMP_InputField>().text=""+PlayerPrefs.GetFloat("valor4",0);
      InputVal5.GetComponent<TMP_InputField>().text=""+PlayerPrefs.GetFloat("valor5",0);
      Valor1=PlayerPrefs.GetFloat("valor1",0);
      Valor2=PlayerPrefs.GetFloat("valor2",0);
      Valor3=PlayerPrefs.GetFloat("valor3",0);
      Valor4=PlayerPrefs.GetFloat("valor4",0);
      Valor5=PlayerPrefs.GetFloat("valor5",0);

}

         public float Valor1   // 
  {
    get { return valor1; }
    set { valor1 = value; }
  }
           public float Valor2   // 
  {
    get { return valor2; }
    set { valor2 = value; }
  }
           public float Valor3   // 
  {
    get { return valor3; }
    set { valor3 = value; }
  }
           public float Valor4   // 
  {
    get { return valor4; }
    set { valor4 = value; }
  }

             public float Valor5   // 
  {
    get { return valor5; }
    set { valor5 = value; }
  }
}
