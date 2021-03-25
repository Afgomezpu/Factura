using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;

// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.DataTime;


public class Principal : MonoBehaviour
{
    public GameObject Nombre;
    public GameObject Direccion;
    public GameObject DireccionPostal;
    public GameObject  fechaFactura;
    public GameObject Facturadesdehasta;
    public GameObject DiaDefactura;
    public GameObject ConsumoActiva;
    public GameObject LecturaActual;
    public GameObject LeccturaAnterior;
    public GameObject FactorMultiplicacion;
    public GameObject ConsumoReactiva;
    public GameObject LecturaActualReactiva;
    public GameObject LecturaAnteriorReactiva;
    public GameObject FactorMultiplicacionReactiva;
    public TMP_Dropdown Municipio;
    public TMP_Dropdown Estrato;  
    public GameObject TotalKilowatios;
    public GameObject Subsidio;  
    System.DateTime Desde;
    System.DateTime Hasta;
    System.TimeSpan Resultado;
    System.String valor;
    string Myformat;
    string prueba;

    void Start()
    {   
        // DropdownItemSelected(Municipio);
        // Municipio.onValueChanged.AddListener(delegate{DropdownItemSelected(Municipio);});
        // DropdownItemSelected(Estrato);
        // Estrato.onValueChanged.AddListener(delegate{DropdownItemSelectedEstrato(Estrato);});
        Myformat=@"ddMMyyyy";
        prueba="12/ene/2021";
        valor=@"12/ene/2021";
        // Desde= new System.DateTime.TryParseExact(prueba,Myformat,CultureInfo.InvariantCulture);
        Hasta=System.DateTime.ParseExact(valor,ParseClient.DateFormatString,System.Globalization.CultureInfo.InvariantCulture);
           
        // Hasta=new System.DateTime((long).ToDouble(prueba));
        //  Desde=new System.DateTime(2014,11,16Convert);
         
        //  Resultado=Desde.Subtract(10);
          print(Hasta.ToString());
    }

    
    void Update()
    {
        
    }

    // void DropdownItemSelected(TMP_Dropdown dropdown){
    //     int index=dropdown.value;

    // }

    // void DropdownItemSelectedEstrato(TMP_Dropdown dropdown){
    //     int index=dropdown.value;
        
    // }
}
