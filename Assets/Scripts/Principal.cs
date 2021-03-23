using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DataTime;


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
    DateTime fecha;
    


    void Start()
    {   
        DropdownItemSelected(Municipio);
        Municipio.onValueChanged.AddListener(delegate{DropdownItemSelected(Municipio);});
        DropdownItemSelected(Estrato);
        Estrato.onValueChanged.AddListener(delegate{DropdownItemSelectedEstrato(Estrato);});
        fecha = new DateTime("13/mar/2021");
    }

    
    void Update()
    {
        
    }

    void DropdownItemSelected(TMP_Dropdown dropdown){
        int index=dropdown.value;

    }

    void DropdownItemSelectedEstrato(TMP_Dropdown dropdown){
        int index=dropdown.value;
        
    }
}
